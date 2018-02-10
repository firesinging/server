using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.logger;

using Libraries.helpers.package;
using Libraries.packages.game;


namespace Game.Command
{

    public class BRequestQueueLocation : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestQueueLocation Request = new PacketBRequestQueueLocation(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            PacketBResponseQueueLocation ResponseContent = new PacketBResponseQueueLocation(0, 1, 1);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseQueueLocation, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
