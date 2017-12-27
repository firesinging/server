using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Reads content packet PacketBBotNetBasePacketCustomChatPopCountRequest.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatPopCountRequest
    {

        public string ChannelName { get; }

        public PacketBBotNetBasePacketCustomChatPopCountRequest(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int ChannelNameLength = Reader.ReadInt32();
                    ChannelName = Encoding.Default.GetString(Reader.ReadBytes(ChannelNameLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketCustomChatPopCountRequest\r\n" +
                "ChannelName = {0}\r\n",
                ChannelName
            );

        }

    }

}
