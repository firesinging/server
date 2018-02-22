using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestSellItem.
    /// </summary>
    public class PacketBRequestSellItem
    {

        public int Index { get; }

        public string VendorInventory { get; }
        public string Inventory { get; }        

        public PacketBRequestSellItem(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int VendorInventoryLength = Reader.ReadInt32();

                    VendorInventory = Encoding.Unicode.GetString(Reader.ReadBytes(VendorInventoryLength));

                    int InventoryLength = Reader.ReadInt32();

                    Inventory = Encoding.Unicode.GetString(Reader.ReadBytes(InventoryLength));

                    Index = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestSellItem\r\n",
               "VendorInventory = {0}\r\n" +
               "Inventory = {1}\r\n" +
               "Index = {2}",
               VendorInventory,
               Inventory,
               Index
           );

        }

    }

}
