using System.IO;
using System.Text;


namespace Libraries.packages.authentication
{

    /// <summary>
    /// Reads content packet PacketBRequestInitialConnection.
    /// </summary>
    public class PacketBRequestInitialConnection
    {

        public long Xuid { get; }
        public string PlayerName { get; }
        public int Connections { get; }
        public string Unk0 { get; }
        public string Language { get; }
        public byte Unk1 { get; }        

        /// <summary>
        /// Resolves the package content.
        /// </summary>
        /// <param name="request">The request content.</param>
        public PacketBRequestInitialConnection(byte[] request)
        {

            using (var Stream = new MemoryStream(request))
            {

                using (var Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();

                    var PlayerNameLength = Reader.ReadInt32();
                    PlayerName = Encoding.Unicode.GetString(Reader.ReadBytes(PlayerNameLength));

                    Connections = Reader.ReadInt32();

                    var Unk0Length = Reader.ReadInt32();
                    Unk0 = Encoding.Unicode.GetString(Reader.ReadBytes(Unk0Length));

                    var LanguageLength = Reader.ReadInt32();
                    Language = Encoding.Unicode.GetString(Reader.ReadBytes(LanguageLength));

                    Unk1 = Reader.ReadByte();

                }

            }

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestInitialConnection\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "PlayerId = {1}\r\n" +
                "PlayerName = {2}\r\n" +
                "Unk0 = {3}\r\n" +
                "Language = {4}\r\n" +
                "Unk1 = {5}\r\n",
                Xuid,
                0,
                PlayerName,
                Unk0,
                Language,
                Unk1
            );

        }

    }

}
