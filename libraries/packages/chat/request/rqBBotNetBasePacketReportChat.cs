using System.IO;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Reads content packet PacketBBotNetBasePacketReportChat.
    /// </summary>
    public class PacketBBotNetBasePacketReportChat
    {

        public long Xuid { get; }

        public PacketBBotNetBasePacketReportChat(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketReportChat\r\n" +
                "Xuid = 0x{0:X}\r\n",
                Xuid
            );

        }

    }

}