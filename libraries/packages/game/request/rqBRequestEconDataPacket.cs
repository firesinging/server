using System.IO;
using System.Text;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestEconDataPacket.
    /// </summary>
    public class PacketBRequestEconDataPacket
    {

        public string ContentString { get; }

        public PacketBRequestEconDataPacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int OutputSize = Reader.ReadInt32();
                    int InputSize = Reader.ReadInt32();

                    byte[] Content = Reader.ReadBytes(InputSize);

                    ContentString = Encoding.UTF8.GetString(PackageZipProtection.Decompress(Content));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestEconDataPacket\r\n" +
                "Content = {0}\r\n",
                ContentString
            );

        }

    }

}
