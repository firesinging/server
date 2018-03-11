using System.Linq;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Metadata;
using SuperSocket.WebSocket.SubProtocol;

using Libraries.manager.models;


namespace Manager.Command
{
    
    /// <summary>
    /// Stop command, which is used for stopping AppServer instance
    /// </summary>
    public class STOP : AsyncJsonSubCommand<Session, string>
    {
        
        /// <summary>
        /// Executes the async json command.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="token">The token.</param>
        /// <param name="commandInfo">The command info.</param>
        protected override void ExecuteAsyncJsonCommand(Session s, string token, string commandInfo)
        {
            
            if (!s.IsAuthenticated)
            {

                s.Close();

                return;

            }

            string InstanceName = commandInfo;

            IWorkItem Server = s.AppServer.GetServerByName(InstanceName);

            if (Server == null)
            {

                SendJsonMessage(s, token, new CommandResult { Result = false, Message = string.Format("The server instance \"{0}\" doesn't exist", commandInfo) });

                return;

            }

            Server.Stop();

            NodeStatus NodeStatus = s.AppServer.CurrentNodeStatus;
            StatusInfoCollection Instance = NodeStatus.InstancesStatus.FirstOrDefault(i => i.Name.Equals(InstanceName));

            Instance[StatusInfoKeys.IsRunning] = false;

            SendJsonMessage(s, token, new CommandResult { Result = true, NodeStatus = NodeStatus });
            
        }

    }

}
