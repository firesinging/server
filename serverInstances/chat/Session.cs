using System;
using SuperSocket.SocketBase;

using Libraries.helpers.package;


namespace Chat
{

    public class Session : AppSession<Session, PackageChat>
    {

        /// <summary>
        /// Called when [session started].
        /// </summary>
        protected override void OnSessionStarted()
        {

            Console.WriteLine($"{AppServer.Name}: Session created {SessionID} from {RemoteEndPoint.Address.ToString()}");

        }

        /// <summary>
        /// Override called when [session closed].
        /// </summary>
        /// <param name="reason">The reason.</param>
        protected override void OnSessionClosed(CloseReason reason)
        {

            Logger.Info($"Chat::OnSessionClosed - Session closed. Reason: {reason}");

        }

        /// <summary>
        /// Handle Unknown request
        /// </summary>
        /// <param name="content"></param>
        protected override void HandleUnknownRequest(PackageChat content)
        {

            Logger.Debug($"Chat::HandleUnknownRequest - Unknown package. Content: {content}");

        }        

    }

}
