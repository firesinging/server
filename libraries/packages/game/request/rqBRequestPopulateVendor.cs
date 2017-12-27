using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestPopulateVendor.
    /// </summary>
    public class PacketBRequestPopulateVendor
    {

        public string VendorProtoUnit { get; }
        public string Unk0 { get; }

        public PacketBRequestPopulateVendor(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int VendorProtoUnitLength = Reader.ReadInt32();
                    VendorProtoUnit = Encoding.Unicode.GetString(Reader.ReadBytes(VendorProtoUnitLength));

                    int Unk0Length = Reader.ReadInt32();
                    Unk0 = Encoding.Unicode.GetString(Reader.ReadBytes(Unk0Length));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestPopulateVendor\r\n",
                "VendorProtoUnit = {0}\r\n" +
                "Unk0 = {1}",
                VendorProtoUnit,
                Unk0
            );

        }

    }

}
