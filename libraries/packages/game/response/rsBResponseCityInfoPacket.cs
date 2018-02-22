using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 52.
    /// </summary>
    public class PacketBResponseCityInfoPacket
    {

        public byte NotExists { get; }

        public long Unk0 { get; }
        public long Xuid { get; }

        public string PlayerName { get; }
        public string Xml { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="notExists">Flag if player does not exists.</param>
        /// <param name="playerName">The player name.</param>
        /// <param name="unk0">Unknown.</param>
        /// <param name="xuid">The Xuid.</param>
        /// <param name="xml">The empire.</param>
        public PacketBResponseCityInfoPacket(byte notExists, string playerName, long unk0, long xuid, string xml)
        {

            NotExists = notExists;
            PlayerName = playerName;
            Unk0 = unk0;
            Xuid = xuid;
            Xml = xml;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (var Stream = new MemoryStream())
            {

                using (var Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    byte[] ContentPlayerName = Encoding.Unicode.GetBytes(PlayerName);
                    byte[] ContentXml = Encoding.Unicode.GetBytes(Xml);

                    Writer.Write(NotExists);
                    Writer.Write(ContentPlayerName.Length);
                    Writer.Write(ContentPlayerName);
                    Writer.Write(Unk0);
                    Writer.Write(Xuid);
                    Writer.Write(ContentXml.Length);
                    Writer.Write(ContentXml);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(
                "PacketBResponseCityInfoPacket\r\n" +
                "NotExists = {0}\r\n" +
                "PlayerName = {1}\r\n" +
                "Unk0 = {2}\r\n" +
                "Xuid = 0x{3:X}\r\n" +
                "Xml = {4}",
                NotExists,
                PlayerName,
                Unk0,
                Xuid,
                Xml
            );

        }

    }

}
