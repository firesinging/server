using SuperSocket.SocketBase.Command;

using Libraries.player;
using Libraries.database;
using Libraries.enums;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestCityInfoPacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestCityInfoPacket Request = new PacketBRequestCityInfoPacket(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Player ObjPlayer = Database.Players.Get(Request.Xuid);

            PacketBResponseCityInfoPacket ResponseContent;

            if (ObjPlayer != null)
            {

                ResponseContent = new PacketBResponseCityInfoPacket(0, ObjPlayer.Name, 0, ObjPlayer.Id, ObjPlayer.Empire.ToXml);

            } else
            {

                ResponseContent = new PacketBResponseCityInfoPacket(1, string.Empty, 0, 0, string.Empty);

            }

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseCityInfoPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
