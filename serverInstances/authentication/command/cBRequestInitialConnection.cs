using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.authentication;
using Libraries.enums;


namespace Authentication.command
{

    public class BRequestInitialConnection : CommandBase<Session, Package>
    {

        public const short GamePort = 1510;

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestInitialConnection Request = new PacketBRequestInitialConnection(p.Content);

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            PacketBResponseInitialConnection ResponseContent = new PacketBResponseInitialConnection(Request.Xuid, 0, 1, string.Empty, string.Empty, GamePort, string.Empty, string.Empty);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseInitialConnection, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
