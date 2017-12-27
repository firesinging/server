using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestRetrievePersistentData.
    /// </summary>
    public class PacketBRequestRetrievePersistentData
    {

        public long Xuid { get; }
        public long CharacterId { get; }
        
        public byte CharacterFlag { get; }        

        public string CharacterName { get; }

        public PacketBRequestRetrievePersistentData(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();

                    int CharacterNameLength = Reader.ReadInt32();

                    CharacterName = Encoding.Unicode.GetString(Reader.ReadBytes(CharacterNameLength));
                    CharacterId = Reader.ReadInt64();
                    CharacterFlag = Reader.ReadByte();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRetrievePersistentData\r\n",
                "Xuid = 0x{0:X}\r\n" +
                "PlayerId = {1}\r\n" +
                "CharacterName = {2}\r\n" +
                "CharacterId = {3}\r\n" +
                "CharacterFlag = 0x{4:X}",
                Xuid,
                0,
                CharacterName,
                CharacterId,
                CharacterFlag
            );

        }

    }

}
