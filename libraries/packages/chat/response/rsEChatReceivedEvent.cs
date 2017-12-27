using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Packet type 5.
    /// </summary>
    public class PacketEChatReceivedEvent
    {

        public string ChannelName { get; }
        public string PlayerName { get; }
        public string ChatMessage { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="channelName">The channel name.</param>
        /// <param name="playerName">The player name.</param>
        /// <param name="chatMessage">The chat message.</param>
        public PacketEChatReceivedEvent(string channelName, string playerName, string chatMessage)
        {

            ChannelName = channelName;
            PlayerName = playerName;
            ChatMessage = chatMessage;

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
                    byte[] contentChatMessage = Encoding.Default.GetBytes(ChatMessage);

                    Writer.Write(contentChannelName.Length);
                    Writer.Write(contentChannelName);

                    Writer.Write(contentPlayerName.Length);
                    Writer.Write(contentPlayerName);
                    
                    Writer.Write(contentChatMessage.Length);
                    Writer.Write(contentChatMessage);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketEChatReceivedEvent\r\n" +
                "ChannelName = {0}\r\n" +
                "PlayerName = {1}\r\n" +
                "ChatMessage = {2}\r\n",
                ChannelName,
                PlayerName,
                ChatMessage
            );

        }

    }

}
