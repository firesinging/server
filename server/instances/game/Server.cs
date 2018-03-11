using System.Linq;
using System.Collections.Generic;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

using Libraries.helpers.server;
using Libraries.helpers.package;


namespace Game
{

    [PackageCommandFilter]
    public class Server : AppServer<Session, Package>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        public Server() : base(new DefaultReceiveFilterFactory<PackageParser, Package>())
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


    }

}
