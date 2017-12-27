using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Packet type 15.
    /// </summary>
    public class PacketBBotNetBasePacketDirectChatDataResponse
    {

        public string PlayerName { get; }
        public string Unk0 { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="playerName">The player name.</param>
        /// <param name="unk0">Unknown.</param>
        public PacketBBotNetBasePacketDirectChatDataResponse(string playerName, string unk0)
        {

            PlayerName = playerName;
            Unk0 = unk0;

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

                    byte[] contentPlayerName = Encoding.Default.GetBytes(PlayerName);
                    byte[] contentUnk0 = Encoding.Default.GetBytes(Unk0);

                    Writer.Write(contentPlayerName.Length);
                    Writer.Write(contentPlayerName);

                    Writer.Write(contentUnk0.Length);
                    Writer.Write(contentUnk0);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketDirectChatDataResponse\r\n" +
                "PlayerName = {0}\r\n" +
                "Unk0 = {1}\r\n",
                PlayerName,
                Unk0
            );

        }

    }

}
