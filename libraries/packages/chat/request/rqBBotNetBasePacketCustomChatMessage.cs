using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Reads content packet PacketBBotNetBasePacketCustomChatMessage.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatMessage
    {

        public string ChannelName { get; }
        public string PlayerName { get; }
        public string ChatMessage { get; }

        public PacketBBotNetBasePacketCustomChatMessage(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int ChannelNameLength = Reader.ReadInt32();
                    ChannelName = Encoding.Default.GetString(Reader.ReadBytes(ChannelNameLength));

                    int PlayerNameLength = Reader.ReadInt32();
                    PlayerName = Encoding.Default.GetString(Reader.ReadBytes(PlayerNameLength));

                    int ChatMessageLength = Reader.ReadInt32();
                    ChatMessage = Encoding.Default.GetString(Reader.ReadBytes(ChatMessageLength));                    

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketCustomChatMessage\r\n" +
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
