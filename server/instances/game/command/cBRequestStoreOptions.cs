using SuperSocket.SocketBase.Command;

using Libraries.player;
using Libraries.enums;
using Libraries.logger;
using Libraries.packages.game;
using Libraries.database.models.player;

using Libraries.helpers.package;
using Libraries.helpers.xml;


namespace Game.Command
{

    public class BRequestStoreOptions : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestStoreOptions Request = new PacketBRequestStoreOptions(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Player ObjPlayer = s.GetPlayer();

            ObjPlayer.Settings = new ModelPlayerSettings().DeserializeFromXml(Request.ContentString);

            PacketBResponseStoreOptions ResponseContent = new PacketBResponseStoreOptions(1);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseStoreOptions, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
