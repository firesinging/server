using System.Collections.Generic;
using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.character;
using Libraries.logger;
using Libraries.inventory;
using Libraries.packages.game;
using Libraries.database.models.inventory;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestInventoryDataPacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestInventoryDataPacket Request = new PacketBRequestInventoryDataPacket(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            InitInventory(s, p);

        }

        /// <summary>
        /// Init character inventory.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet PacketBRequestInventoryDataPacket, PacketBRequestPopulateVendor or BRequestCityDataPacket.</param>
        public static void InitInventory(Session s, Package p)
        {

            Logger.Debug($"{p.Key}::InitInventory");

            Character ObjCharacter = s.Player.Empire.CurrentCharacter;

            foreach (KeyValuePair<string, Inventory> Item in ObjCharacter.Inventories.Items)
            {

                SendResponseGetContainerNumSlots(s, p, Item.Value.Info, 1);
                SendResponseStringListInventory(s, p, Item.Value.Inventory.ToXml);

            }

        }

        /// <summary>
        /// Sends BResponseGetContainerNumSlots.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet PacketBRequestInventoryDataPacket, PacketBRequestPopulateVendor or BRequestCityDataPacket.</param>
        /// <param name="i">The container information.</param>
        /// <param name="flag">Flag.</param>
        public static void SendResponseGetContainerNumSlots(Session s, Package p, ModelInventoryInfo i, byte flag = 0)
        {

            Character ObjCharacter = s.Player.Empire.CurrentCharacter;

            PacketBResponseGetContainerNumSlots ResponseContent = new PacketBResponseGetContainerNumSlots(ObjCharacter.Id, i.Id, i.Maxcapacity, 0, flag);

            Logger.Debug($"{p.Key}::SendResponseGetContainerNumSlots - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseGetContainerNumSlots, 0, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for inventory.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet PacketBRequestInventoryDataPacket or PacketBRequestPopulateVendor.</param>
        /// <param name="xml">The inventory xml.</param>
        public static void SendResponseStringListInventory(Session s, Package p, string xml)
        {

            if (!string.IsNullOrEmpty(xml))
            {

                Character ObjCharacter = s.Player.Empire.CurrentCharacter;

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Inventory, ObjCharacter.Id, xml);

                Logger.Debug($"{p.Key}::SendResponseStringListInventory - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }            

        }

    }

}
