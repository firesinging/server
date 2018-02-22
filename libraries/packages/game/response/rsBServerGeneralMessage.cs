using System.IO;

using Libraries.enums;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 120.
    /// </summary>
    public class PacketBServerGeneralMessage
    {

        public ServerMessagesTypes Type { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="type">The message type.</param>
        public PacketBServerGeneralMessage(ServerMessagesTypes type)
        {

            Type = type;

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

                    Writer.Write((int) Type);

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
                "PacketBServerGeneralMessage\r\n" +
                "Type = {0}\r\n",
                Type
            );

        }

    }

}
