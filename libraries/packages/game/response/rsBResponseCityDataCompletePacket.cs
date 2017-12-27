using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 58.
    /// </summary>
    public class PacketBResponseCityDataCompletePacket
    {

        public long Xuid { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="request">The request.</param>
        public PacketBResponseCityDataCompletePacket(long xuid)
        {

            Xuid = xuid;

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

                    Writer.Write(Xuid);

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
                "PacketBResponseCityDataCompletePacket\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "PlayerId = {1}\r\n",
                Xuid,
                0
            );

        }

    }

}
