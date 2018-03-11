using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Metadata;
using SuperSocket.WebSocket;
using SuperSocket.WebSocket.SubProtocol;
using Newtonsoft.Json;

using Libraries.manager.models;

using Libraries.helpers.json;
using Libraries.helpers.server;
using Libraries.helpers.package;


namespace Manager
{

    [PackageCommandFilter]
    public class Server : WebSocketServer<Session>
    {

        private NodeStatus m_CurrentNodeStatus;

        private List<KeyValuePair<string, StatusInfoAttribute[]>> m_ServerStatusMetadataSource;
        private static JsonConverter m_IPEndPointConverter = new ListenersJsonConverterHelper();

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        public Server() : base(new BasicSubProtocol<Session>("Manager"))
        {

        }

        /// <summary>
        /// Start the server and load the database.
        /// </summary>
        /// <returns>True if the server is started and the database loaded.</returns>
        public override bool Start()
        {

            if (ServerHelper.OnServerStart())
            {

                return base.Start();

            }
            else
            {

                Stop();

                return false;

            }

        }

        /// <summary>
        /// Close expired sessions for player.
        /// </summary>
        /// <param name="id">The player id.</param>
        /// <param name="currentSessionID">The current session id.</param>
        public void CloseExpiredSessions(long id, string currentSessionID)
        {

            List<Session> ObjSessions = base.GetSessions(s => s.Player.Id == id && s.SessionID != currentSessionID).ToList();

            foreach (Session ObjSession in ObjSessions)
            {

                try
                {

                    ObjSession.Close();

                }

                catch
                {

                }

            }

        }

        /// <summary>
        /// Gets the server status metadata source.
        /// </summary>
        /// <value>
        /// The server status metadata source.
        /// </value>
        internal List<KeyValuePair<string, StatusInfoAttribute[]>> ServerStatusMetadataSource
        {

            get
            {

                return m_ServerStatusMetadataSource;

            }

        }        

        /// <summary>
        /// Gets the current node status.
        /// </summary>
        /// <value>
        /// The current node status.
        /// </value>
        internal NodeStatus CurrentNodeStatus
        {

            get
            {

                return m_CurrentNodeStatus;

            }

        }   

        /// <summary>
        /// Gets the name of the server by.
        /// </summary>
        /// <param name="serverName">Name of the server.</param>
        /// <returns></returns>
        internal IWorkItem GetServerByName(string serverName)
        {

            return Bootstrap.AppServers.FirstOrDefault(s => s.Name.Equals(serverName, StringComparison.OrdinalIgnoreCase));

        }

        private void BroadcastServerUpdate()
        {

            string message = string.Format("{0} {1}", CommandName.UPDATE, JsonSerialize(m_CurrentNodeStatus));

            foreach (var s in this.GetSessions(s => s.Connected && s.IsAuthenticated))
            {

                s.TrySend(message);

            }

        }

        private void OnServerStatusCollected(object status)
        {

            NodeStatus nodeStatus = (NodeStatus) status;
            nodeStatus.InstancesStatus = nodeStatus.InstancesStatus.ToArray();
            m_CurrentNodeStatus = nodeStatus;

            if (Monitor.TryEnter(m_CurrentNodeStatus))
            {

                try
                {

                    BroadcastServerUpdate();

                }
                catch (Exception e)
                {

                    Logger.Error("BroadcastServerUpdate error", e);

                }

                finally
                {

                    Monitor.Exit(m_CurrentNodeStatus);

                }

            }

        }

        protected override void OnSystemMessageReceived(string messageType, object messageData)
        {
            
            if (messageType == "ServerStatusCollected")
            {

                this.AsyncRun(OnServerStatusCollected, messageData);

            }
            else if (messageType == "ServerMetadataCollected")
            {

                m_ServerStatusMetadataSource = ((List<KeyValuePair<string, StatusInfoAttribute[]>>)messageData).ToList();

            }

        }       

        /// <summary>
        /// Jsons the serialize.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <returns></returns>
        public override string JsonSerialize(object target)
        {

            return JsonConvert.SerializeObject(target, m_IPEndPointConverter);

        }

    }

}