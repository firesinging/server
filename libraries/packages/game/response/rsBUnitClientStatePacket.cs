using System.IO;
using System.Text;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 153.
    /// </summary>
    public class PacketBUnitClientStatePacket
    {

        public byte Flag { get; }

        public string UnitStateXml { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="unitStateXml">The unit state XML.</param>
        /// <param name="flag">Flag.</param>
        public PacketBUnitClientStatePacket(string unitStateXml, byte flag)
        {

            UnitStateXml = unitStateXml;
            Flag = flag;

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

                    byte[] Content = Encoding.UTF8.GetBytes(UnitStateXml);
                    byte[] ContentProtected = PackageZipProtection.Compress(Content);

                    int InputSize = Content.Length;
                    int OutputSize = ContentProtected.Length;

                    Writer.Write(InputSize);
                    Writer.Write(OutputSize);
                    Writer.Write(ContentProtected);
                    Writer.Write(Flag);

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
                "PacketBUnitClientStatePacket\r\n" +
                "UnitStateXml = {0}\r\n" +
                "Flag = {1}\r\n",
                UnitStateXml,
                Flag
            );

        }

    }

}
