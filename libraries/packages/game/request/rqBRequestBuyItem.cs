using System.IO;
using System.Text;

using Libraries.enums;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestBuyItem.
    /// </summary>
    public class PacketBRequestBuyItem
    {      

        public string ProtoName { get; }
        public string Item { get; }

        public InventoryItemTypes Type { get; }

        public PacketBRequestBuyItem(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int ProtoNameLength = Reader.ReadInt32();

                    ProtoName = Encoding.Unicode.GetString(Reader.ReadBytes(ProtoNameLength));

                    InventoryItemTypes Type = (InventoryItemTypes) Reader.ReadInt32();
                    int ItemLength = Reader.ReadInt32();

                    Item = Encoding.Unicode.GetString(Reader.ReadBytes(ItemLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestBuyItem\r\n",
                "ProtoName = {0}\r\n" +
                "Type = {1}\r\n" +
                "Item = {2}",
                ProtoName,
                Type,
                Item
            );

        }

    }

}
