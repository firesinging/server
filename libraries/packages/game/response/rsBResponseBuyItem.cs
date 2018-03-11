using System.IO;
using System.Text;

using Libraries.enums;

namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 110.
    /// </summary>
    public class PacketBResponseBuyItem
    {

        public byte Result { get; }        

        public string ProtoName { get; }
        public string Item { get; }

        public InventoryItemTypes Type { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="protoName">The protounit.</param>
        /// <param name="type">The item type.</param>
        /// <param name="item">The item name.</param>
        /// <param name="result">The result.</param>
        public PacketBResponseBuyItem(string protoName, InventoryItemTypes type, string item, byte result)
        {

            ProtoName = protoName;
            Type = type;
            Item = item;
            Result = result;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (var Stream = new MemoryStream())
            {

                using (var Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    byte[] ContentProtoName = Encoding.Unicode.GetBytes(ProtoName);
                    byte[] ContentItem = Encoding.Unicode.GetBytes(Item);

                    Writer.Write(ContentProtoName.Length);
                    Writer.Write(ContentProtoName);
                    Writer.Write((int) Type);
                    Writer.Write(ContentItem.Length);
                    Writer.Write(ContentItem);
                    Writer.Write(Result);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(
                "PacketBResponseBuyItem\r\n" +
                "ProtoName = {0}\r\n" +
                "Type = {1}\r\n" +
                "Item = {2}\r\n" +
                "Result = {3}",
                ProtoName,
                Type,
                Item,
                Result
            );

        }

    }

}
