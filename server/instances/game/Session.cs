using System.Linq;
using SuperSocket.SocketBase;

using Libraries.player;

using Libraries.helpers.package;


namespace Game
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

                Logger.Info($"Game::Player - Set session player {value.Name}");

                AppServer.CloseExpiredSessions(value.Id, SessionID);

                _Player = value;
                _Player.SessionGame = SessionID;

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

            Logger.Info($"Game::OnSessionStarted - {AppServer.Name} Session created with Id {SessionID} from IP {RemoteEndPoint.Address.ToString()}");
            
        }

        /// <summary>
        /// Override called when [session closed].
        /// </summary>
        /// <param name="reason">The reason.</param>
        protected override void OnSessionClosed(CloseReason reason)
        {

            Logger.Info($"Game::OnSessionClosed - Session closed. Reason: {reason}");

            if (IsAuthenticated)
            {

                _Player.SessionGame = null;
                _Player.Save();

            }             

        }
        
        /// <summary>
        /// Handle Unknown request
        /// </summary>
        /// <param name="content">The package content.</param>
        protected override void HandleUnknownRequest(Package content)
        {

            Logger.Debug($"Game::HandleUnknownRequest - Unknown package. Content: {content}");               

        }

    }

}
