using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Packet type 3.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatLeaveChannelEvent
    {

        public string ChannelName { get; }
        public string PlayerName { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="channelName">The channel name.</param>
        /// <param name="playerName">The player name.</param>
        public PacketBBotNetBasePacketCustomChatLeaveChannelEvent(string channelName, string playerName)
        {

            ChannelName = channelName;
            PlayerName = playerName;

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

                    byte[] contentChannelName = Encoding.Default.GetBytes(ChannelName);
                    byte[] contentPlayerName = Encoding.Default.GetBytes(PlayerName);
                    
                    Writer.Write(contentChannelName.Length);
                    Writer.Write(contentChannelName);

                    Writer.Write(contentPlayerName.Length);
                    Writer.Write(contentPlayerName);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketCustomChatLeaveChannelEvent\r\n" +
                "ChannelName = {0}\r\n" +
                "PlayerName = {1}\r\n",
                ChannelName,
                PlayerName
            );

        }

    }

}
