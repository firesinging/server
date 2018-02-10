using SuperSocket.SocketBase.Command;

using Libraries.packages.game;
using Libraries.enums;
using Libraries.logger;

using Libraries.helpers.package;


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

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            PacketBResponseUserAuthentication ResponseContent = new PacketBResponseUserAuthentication(Request.Xuid, 0);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseUserAuthentication, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}