using SuperSocket.SocketBase;
using SuperSocket.WebSocket;
using SuperSocket.WebSocket.Protocol;
using SuperSocket.WebSocket.SubProtocol;

using Libraries.player;


namespace Manager
{
    
    /// <summary>
    /// Management session
    /// </summary>
    public class Session : WebSocketSession<Session>
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
        /// <returns>The player object.</returns>
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

                Logger.Info($"Manager::Player - Set session player {value.Name}");

                AppServer.CloseExpiredSessions(value.Id, SessionID);

                _Player = value;
                _Player.SessionManager = SessionID;

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

            Logger.Info($"Manager::OnSessionStarted - {AppServer.Name} Session created with Id {SessionID} from IP {RemoteEndPoint.Address.ToString()}");

        }

        /// <summary>
        /// Override called when [session closed].
        /// </summary>
        /// <param name="reason">The reason.</param>
        protected override void OnSessionClosed(CloseReason reason)
        {

            Logger.Info($"Manager::OnSessionClosed - Session closed. Reason: {reason}");

            if (IsAuthenticated)
            {

                _Player.SessionManager = null;
                _Player.Save();

            }

        }

        /// <summary>
        /// Handle Unknown request
        /// </summary>
        /// <param name="content">The package content.</param>
        protected override void HandleUnknownRequest(IWebSocketFragment content)
        {

            Logger.Debug($"Manager::HandleUnknownRequest - Unknown package. Content: {content}");

        }

        /// <summary>
        /// Handle Unknown request
        /// </summary>
        /// <param name="content">The package sub content.</param>
        protected override void HandleUnknownCommand(SubRequestInfo content)
        {

            Logger.Debug($"Manager::HandleUnknownRequest - Unknown package. Content: {content}");

        }

    }

}