using System.IO;
using System.Text;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestStoreOptions.
    /// </summary>
    public class PacketBRequestStoreOptions
    {

        public long Xuid { get; }

        public string ContentString { get; }

        public PacketBRequestStoreOptions(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();

                    int OutputSize = Reader.ReadInt32();
                    int InputSize = Reader.ReadInt32();

                    byte[] Content = Reader.ReadBytes(InputSize);

                    ContentString = Encoding.Unicode.GetString(PackageZipProtection.Decompress(Content));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestStoreOptions\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "Content = {1}\r\n",
                Xuid,
                ContentString
            );

        }

    }

}
