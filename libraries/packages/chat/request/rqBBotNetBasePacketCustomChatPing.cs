using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Reads content packet PacketBBotNetBasePacketCustomChatPing.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatPing
    {

        public string PlayerName { get; }

        public PacketBBotNetBasePacketCustomChatPing(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int PlayerNameLength = Reader.ReadInt32();

                    PlayerName = Encoding.Default.GetString(Reader.ReadBytes(PlayerNameLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketCustomChatPing\r\n" +
                "PlayerName = {0}\r\n",
                PlayerName
            );

        }

    }

}
