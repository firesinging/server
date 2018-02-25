using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestPopulateVendor.
    /// </summary>
    public class PacketBRequestPopulateVendor
    {

        public string Vendor { get; }
        public string Container { get; }

        public PacketBRequestPopulateVendor(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int VendorLength = Reader.ReadInt32();
                    Vendor = Encoding.Unicode.GetString(Reader.ReadBytes(VendorLength));

                    int ContainerLength = Reader.ReadInt32();
                    Container = Encoding.Unicode.GetString(Reader.ReadBytes(ContainerLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestPopulateVendor\r\n",
                "Vendor = {0}\r\n" +
                "Container = {1}",
                Vendor,
                Container
            );

        }

    }

}
