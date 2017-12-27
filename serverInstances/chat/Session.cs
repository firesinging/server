using System;
using SuperSocket.SocketBase;

using Libraries.helpers.package;
using Libraries.player;

namespace Chat
{

    public class Session : AppSession<Session, PackageChat>
    {

        public string PlayerName { get; internal set; }
        public string Password { get; internal set; }

        public string CharacterName = "FireSinger";

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
                Logger.Info($"Chat::OnSessionClosed - Session closed. Reason: ({reason})");

        }

        /// <summary>
        /// Handle Unknown request
        /// </summary>
        /// <param name="content"></param>
        protected override void HandleUnknownRequest(PackageChat content)
        {

            if (Logger.IsDebugEnabled)
                Logger.Debug($"Chat::HandleUnknownRequest - Unknown package. Content: {content}");

        }        

    }

}
