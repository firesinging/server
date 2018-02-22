using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestUseConsumable.
    /// </summary>
    public class PacketBRequestUseConsumable
    {

        public int Index { get; }

        public byte Type { get; }

        public string Inventory { get; }

        public PacketBRequestUseConsumable(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int InventoryLength = Reader.ReadInt32();

                    Inventory = Encoding.Unicode.GetString(Reader.ReadBytes(InventoryLength));
                    Index = Reader.ReadInt32();
                    Type = Reader.ReadByte();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestUseConsumable\r\n" +
               "Inventory = {0}\r\n" +
               "Index = {1}\r\n" +
               "Type = {2}\r\n",
               Inventory,
               Index,
               Type
           );

        }

    }

}
