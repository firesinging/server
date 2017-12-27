using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Reads content packet BBotNetBasePacketCustomChatJoinChannelRequest.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatJoinChannelRequest
    {

        public string ChannelName { get; }

        public PacketBBotNetBasePacketCustomChatJoinChannelRequest(byte[] request)
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
                "PacketBBotNetBasePacketCustomChatJoinChannelRequest\r\n" +
                "ChannelName = {0}\r\n",
                ChannelName
            );

        }

    }

}
