using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Reads content packet PacketBBotNetBasePacketCustomRequestLeaveServer.
    /// </summary>
    public class PacketBBotNetBasePacketCustomRequestLeaveServer
    {

        public string PlayerName { get; }

        public PacketBBotNetBasePacketCustomRequestLeaveServer(byte[] request)
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
                "PacketBBotNetBasePacketCustomRequestLeaveServer\r\n" +
                "PlayerName = {0}\r\n",
                PlayerName
            );

        }

    }

}
