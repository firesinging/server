using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestOpenChest.
    /// </summary>
    public class PacketBRequestOpenChest
    {

        public int Index { get; }

        public string Inventory { get; }

        public PacketBRequestOpenChest(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int InventoryLength = Reader.ReadInt32();

                    Inventory = Encoding.Unicode.GetString(Reader.ReadBytes(InventoryLength));
                    Index = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestOpenChest\r\n" +
               "Inventory = {0}\r\n" +
               "Index = {1}\r\n",
               Inventory,
               Index
           );

        }

    }

}
