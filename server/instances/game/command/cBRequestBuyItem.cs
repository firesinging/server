using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.character;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestBuyItem : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestBuyItem Request = new PacketBRequestBuyItem(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Character ObjCharacter = s.Player.Empire.CurrentCharacter;

            PacketBResponseBuyItem ResponseContent;

            if (ObjCharacter.Inventories.TotalCapacity - ObjCharacter.Inventories.TotalItems <= 0)
            {

                ResponseContent = new PacketBResponseBuyItem(Request.ProtoName, Request.Type, Request.Item, 0);

                SendResponseBuyItem(s, p, ResponseContent);

            }

            

        }

        /// <summary>
        /// Sends BResponseBuyItem.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestBuyItem.</param>
        public static void SendResponseBuyItem(Session s, Package p, PacketBResponseBuyItem r)
        {

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {r}");

            byte[] Response = r.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseBuyItem, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
