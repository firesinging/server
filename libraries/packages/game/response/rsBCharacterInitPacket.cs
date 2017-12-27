using System.IO;
using System.Text;

using Libraries.enums;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 41.
    /// </summary>
    public class PacketBCharacterInitPacket
    {

        public long Xuid { get; }
        public long CharacterId { get; }
        public long CharacterFlags { get; }       

        public Civilizations CivilizationId { get; }        

        public string CharacterName { get; }
        public string Unk0 { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="characterName">The character name.</param>
        /// <param name="unk0">Unknown.</param>
        /// <param name="characterFlags">The characters flags.</param>
        /// <param name="characterId">The character id.</param>
        /// <param name="xuid">The Xuid the character belongs to.</param>
        /// <param name="civilizationId">The civilization id the character belongs to.</param>
        public PacketBCharacterInitPacket(string characterName, string unk0, long characterFlags, long characterId, long xuid, Civilizations civilizationId)
        {

            Xuid = xuid;
            CharacterId = characterId;
            CharacterFlags = characterFlags;
            CivilizationId = civilizationId;
            CharacterName = characterName;
            Unk0 = unk0;

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

                    byte[] ContentCharacterName = Encoding.Unicode.GetBytes(CharacterName);
                    byte[] ContentUnk0 = Encoding.Unicode.GetBytes(Unk0);

                    Writer.Write(ContentCharacterName.Length);
                    Writer.Write(ContentCharacterName);
                    Writer.Write(ContentUnk0.Length);
                    Writer.Write(ContentUnk0);
                    Writer.Write(CharacterFlags);
                    Writer.Write(CharacterId);
                    Writer.Write(Xuid);
                    Writer.Write((int)CivilizationId);

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
                "PacketBCharacterInitPacket\r\n" +
                "CharacterName = {0}\r\n" +
                "Unk0 = {1}\r\n" +
                "CharacterFlags = 0x{2:X}\r\n" +
                "CharacterId = {3}\r\n" +
                "Xuid = 0x{4:X}\r\n" +
                "PlayerId = {5}\r\n" +
                "CivilizationId = {6}",
                CharacterName,
                Unk0,
                CharacterFlags,
                CharacterId,
                Xuid,
                0,
                CivilizationId
            );

        }

    }

}
