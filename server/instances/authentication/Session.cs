using System.Linq;
using SuperSocket.SocketBase;

using Libraries.player;

using Libraries.helpers.package;


namespace Authentication
{

    public class Session : AppSession<Session, Package>
    {

        private Player _Player;

        /// <summary>
        /// Check if the player is authenticated.
        /// </summary>
        /// <returns>True if the player is authenticated.</returns>
        public bool IsAuthenticated
        {

            get
            {

                return (_Player != null);

            }

        }

        /// <summary>
        /// The player.
        /// </summary>
        public Player Player
        {

            get
            {

                return _Player;

            }

            internal set
            {

                if ((value == null) || (IsAuthenticated))
                {

                    return;

                }

                Logger.Info($"Authentication::Player - Set session player {value.Name}");

                AppServer.CloseExpiredSessions(value.Id, SessionID);

                _Player = value;
                _Player.SessionAuthentication = SessionID;

            }

        }

        /// <summary>
        /// Gets the app server.
        /// </summary>
        public new Server AppServer
        {

            get
            {

                return (Server)base.AppServer;

            }

        }

        /// <summary>
        /// Called when [session started].
        /// </summary>
        protected override void OnSessionStarted()
        {

            Logger.Info($"Authentication::OnSessionStarted - Session created with Id {SessionID} from IP {RemoteEndPoint.Address.ToString()}");

        }

        /// <summary>
        /// Override called when [session closed].
        /// </summary>
        /// <param name="reason">The reason.</param>
        protected override void OnSessionClosed(CloseReason reason)
        {

            Logger.Info($"Authentication::OnSessionClosed - Session closed. Reason: {reason}");

            if (IsAuthenticated)
            {

                _Player.SessionAuthentication = null;
                _Player.Save();                

            }                

        }

        /// <summary>
        /// Handle Unknown request
        /// </summary>
        /// <param name="content">The package content.</param>
        protected override void HandleUnknownRequest(Package content)
        {

            Logger.Debug($"Authentication::HandleUnknownRequest - Unknown package. Content: {content}");

        }

    }

}