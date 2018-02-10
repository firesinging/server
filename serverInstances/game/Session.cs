using SuperSocket.SocketBase;

using Libraries.enums;
using Libraries.player;
using Libraries.database;

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

                return _Player != null;

            }

        }

        /// <summary>
        /// Get player based on Id.
        /// </summary>
        /// <param name="id">The player Id.</param>
        /// <returns>The player object.</returns>
        public Player GetPlayer(long id = 0)
        {

            Player Instance = _Player;

            if ((id == 0) && (Instance == null))
            {

                return null;

            }

            if ((id != 0) && (id != Instance.Id))
            {

                Instance = Database.Players.Get(id);

            }

            return Instance;

        }

        /// <summary>
        /// Add the player to the session.
        /// </summary>
        /// <param name="player">The player object.</param>
        internal void SetPlayer(Player player)
        {

            _Player = player;
            _Player.SessionGame = SessionID;

        }

        /// <summary>
        /// Called when [session started].
        /// </summary>
        protected override void OnSessionStarted()
        {

            Logger.InfoFormat("Game::OnSessionStarted - {0} Session created with Id {1} from IP {2}", AppServer.Name, SessionID, RemoteEndPoint.Address.ToString());
            
        }

        /// <summary>
        /// Override called when [session closed].
        /// </summary>
        /// <param name="reason">The reason.</param>
        protected override void OnSessionClosed(CloseReason reason)
        {

            Logger.InfoFormat("Game::OnSessionClosed - Session closed. Reason: {0}", reason);

            if (_Player != null)
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

            Logger.DebugFormat("Game::HandleUnknownRequest - Unknown package. Content: {0}", content);               

        }

    }

}
