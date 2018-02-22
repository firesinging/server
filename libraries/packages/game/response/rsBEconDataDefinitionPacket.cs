using System.IO;
using System.Text;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 90.
    /// </summary>
    public class PacketBEconDataDefinitionPacket
    {

        public string ContentString { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="contentString">The content string.</param>
        public PacketBEconDataDefinitionPacket(string contentString)
        {

            ContentString = contentString;

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

                    byte[] Content = Encoding.UTF8.GetBytes(ContentString);
                    byte[] ContentProtected = PackageZipProtection.Compress(Content);

                    int InputSize = Content.Length;
                    int OutputSize = ContentProtected.Length;

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
                "PacketBEconDataDefinitionPacket\r\n" +
                "ContentString = {0}\r\n",
                ContentString
            );

        }

    }

}
