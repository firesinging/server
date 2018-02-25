using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.logger;
using Libraries.packages.authentication;

using Libraries.helpers.package;


namespace Authentication.command
{

    public class BRequestGfWlValid : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestGfWlValid Request = new PacketBRequestGfWlValid(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            PacketBResponseGfWlValid ResponseContent = new PacketBResponseGfWlValid(1);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseGfWlValid, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
