using System.IO;
using System.Text;

namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestUserAuthentication.
    /// </summary>
    public class PacketBRequestUserAuthentication
    {

        public long Xuid { get; }
        public string PlayerName { get; }

        public PacketBRequestUserAuthentication(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    var PlayerNameLength = Reader.ReadInt32();
                    PlayerName = Encoding.Default.GetString(Reader.ReadBytes(PlayerNameLength));

                    Xuid = Reader.ReadInt64();                   

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestUserAuthentication\r\n" +
                "PlayerName = {0}\r\n" +
                "Xuid = 0x{1:X}\r\n" +
                "PlayerId = {2}\r\n",
                PlayerName,
                Xuid,
                0
            );

        }

    }

}
