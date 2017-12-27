using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Reads content packet PacketBBotNetBasePacketCustomChatWhisper.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatWhisper
    {

        public string ToPlayerName { get; }
        public string ChatMessage { get; }

        public PacketBBotNetBasePacketCustomChatWhisper(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int ToPlayerNameLength = Reader.ReadInt32();
                    ToPlayerName = Encoding.Default.GetString(Reader.ReadBytes(ToPlayerNameLength));

                    int ChatMessageLength = Reader.ReadInt32();
                    ChatMessage = Encoding.Default.GetString(Reader.ReadBytes(ChatMessageLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketCustomChatWhisper\r\n" +
                "ToPlayerName = {0}\r\n" +
                "ChatMessage = {1}\r\n",
                ToPlayerName,
                ChatMessage
            );

        }

    }

}

