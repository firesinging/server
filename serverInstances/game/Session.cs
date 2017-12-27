using System;
using SuperSocket.SocketBase;

using Libraries.player;
using Libraries.helpers.package;
using Libraries.enums;


namespace Game
{

    public class Session : AppSession<Session, Package>
    {
        
        

        


        public string PlayerName { get; internal set; }
        public string Password { get; internal set; }

        // @TODO load player
        public string Xuid { get; internal set; }

        public long CharacterId = 1;
        public string CharacterName = "FireSinger";
        public long CharacterFlags = 0x10 | 0x2 | 0x1;
        public Civilizations CharacterCivilizationId = (Civilizations)1;
        public int CharacterLevel = 0;
        public int CharacterXp = 0;
        public byte CharacterMaxAge = 1;
        public int CharacterMaxLevelXp = 1;
        public int Region = 1;
        public int SkillPoints = 1;
        public int SkillResetPoints = 1;
        public int scenarioID = 1;
        public string scenarioName = "";



        /// <summary>
        /// Called when [session started].
        /// </summary>
        protected override void OnSessionStarted()
        {

            Console.WriteLine("{0}: Session created {1} from {2}", AppServer.Name, SessionID, RemoteEndPoint.Address.ToString());

        }

        /// <summary>
        /// Override called when [session closed].
        /// </summary>
        /// <param name="reason">The reason.</param>
        protected override void OnSessionClosed(CloseReason reason)
        {

            if (Logger.IsInfoEnabled)
                Logger.Info($"Game::OnSessionClosed - Session closed. Reason: ({reason})");

        }

        /// <summary>
        /// Handle Unknown request
        /// </summary>
        /// <param name="content"></param>
        protected override void HandleUnknownRequest(Package content)
        {

            if (Logger.IsDebugEnabled)
                Logger.Debug($"Game::HandleUnknownRequest - Unknown package. Content: {content}");

        }        

    }

}
