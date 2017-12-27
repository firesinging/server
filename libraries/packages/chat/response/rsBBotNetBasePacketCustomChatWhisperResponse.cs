using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Packet type 13.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatWhisperResponse
    {

        public string ChannelName { get; }
        public string ChatMessage { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="channelName">The channel name.</param>
        /// <param name="chatMessage">The chat message.</param>
        public PacketBBotNetBasePacketCustomChatWhisperResponse(string channelName, string chatMessage)
        {

            ChannelName = channelName;
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
                    byte[] contentChatMessage = Encoding.Default.GetBytes(ChatMessage);

                    Writer.Write(contentChannelName.Length);
                    Writer.Write(contentChannelName);

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
                "PacketBBotNetBasePacketCustomChatWhisperResponse\r\n" +
                "ChannelName = {0}\r\n" +
                "ChatMessage = {1}\r\n",
                ChannelName,
                ChatMessage
            );

        }

    }

}
