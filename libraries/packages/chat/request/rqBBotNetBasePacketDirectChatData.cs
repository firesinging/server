using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Reads content packet PacketBBotNetBasePacketDirectChatDataRequest.
    /// </summary>
    public class PacketBBotNetBasePacketDirectChatDataRequest
    {

        public string PlayerName { get; }
        public string Unk0 { get; }

        public PacketBBotNetBasePacketDirectChatDataRequest(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int PlayerNameLength = Reader.ReadInt32();
                    PlayerName = Encoding.Default.GetString(Reader.ReadBytes(PlayerNameLength));

                    int Unk0Length = Reader.ReadInt32();
                    Unk0 = Encoding.Default.GetString(Reader.ReadBytes(Unk0Length));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketDirectChatDataRequest\r\n" +
                "PlayerName = {0}\r\n" +
                "Unk0 = {1}\r\n",
                PlayerName,
                Unk0
            );

        }

    }

}
