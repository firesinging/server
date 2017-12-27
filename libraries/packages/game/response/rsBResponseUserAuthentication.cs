using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 0.
    /// </summary>
    public class PacketBResponseUserAuthentication
    {

        public long Xuid { get; }
        public long Server { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="Xuid">Xuid from request content.</param>
        /// <param name="server">The server.</param>
        public PacketBResponseUserAuthentication(long xuid, long server)
        {

            Xuid = xuid;
            Server = server;

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
                    Writer.Write(Server);

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
                "PacketBResponseUserAuthentication\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "PlayerId = {1}\r\n" +
                "Server = {2}\r\n",
                Xuid,
                0,
                Server
            );

        }

    }

}
