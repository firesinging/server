using System.IO;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Packet type 255.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatPong
    {

        public byte PingInterval { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="pingInterval">Ping interval.</param>
        public PacketBBotNetBasePacketCustomChatPong(byte pingInterval)
        {

            PingInterval = pingInterval;

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

                    Writer.Write(PingInterval);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketCustomChatPong\r\n" +
                "PingInterval = {0}\r\n",
                PingInterval
            );

        }

    }

}
