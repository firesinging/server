using System.IO;
using System.Text;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 0.
    /// </summary>
    public class PacketBGetEmpireResponse
    {

        public long Xuid { get; }
        public string PlayerEmpire { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="xuid">The Xuid.</param>
        /// <param name="contentString">The empire content.</param>
        public PacketBGetEmpireResponse(long xuid, string contentString)
        {

            Xuid = xuid;
            PlayerEmpire = contentString;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (MemoryStream Stream = new MemoryStream())
            {

                using (BinaryWriter Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    byte[] Content = Encoding.Unicode.GetBytes(PlayerEmpire);
                    byte[] ContentProtected = PackageZipProtection.Compress(Content);

                    int InputSize = Content.Length;
                    int OutputSize = ContentProtected.Length;

                    Writer.Write(Xuid);
                    Writer.Write(InputSize);
                    Writer.Write(OutputSize);
                    Writer.Write(ContentProtected);

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
                "PacketBGetEmpireResponse\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "PlayerEmpire = {1}\r\n",
                Xuid,
                PlayerEmpire
            );

        }

    }

}
