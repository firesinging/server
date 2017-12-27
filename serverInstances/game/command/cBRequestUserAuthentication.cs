using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.game;
using Libraries.enums;


namespace Game.command
{

    public class BRequestUserAuthentication : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestUserAuthentication Request = new PacketBRequestUserAuthentication(p.Content);

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            PacketBResponseUserAuthentication ResponseContent = new PacketBResponseUserAuthentication(Request.Xuid, 0);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseUserAuthentication, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}