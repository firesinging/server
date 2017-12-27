using System.IO;
using System.Text;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 40.
    /// </summary>
    public class PacketBCharacterDetailsPacket
    {

        public byte CharacterMaxAge { get; }

        public int CharacterLevel { get; }
        public int CharacterXp { get; }
        public int Region { get; }
        public int CharacterMaxLevelXp { get; }
        public int SkillPoints { get; }
        public int SkillResetPoints { get; }

        public long CharacterId { get; }
        
        public string CharacterName { get; }


        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="characterName">The character name.</param>
        /// <param name="characterId">The character id.</param>
        /// <param name="characterlevel">The character current level.</param>
        /// <param name="characterXp">The character current experience points.</param>
        /// <param name="characterMaxAge">The maximum age the character can achieve.</param>
        /// <param name="characterMaxLevelXp">The maximum level experience points.</param>
        /// <param name="region">The characters current region.</param>
        /// <param name="skillPoints">The characters current tech points.</param>
        /// <param name="skillResetPoints">The characters current tech reset points.</param>
        public PacketBCharacterDetailsPacket(string characterName, long characterId, int characterlevel, int characterXp, byte characterMaxAge, int characterMaxLevelXp, int region, int skillPoints, int skillResetPoints)
        {

            CharacterId = characterId;
            CharacterName = characterName;
            CharacterLevel = characterlevel;
            CharacterXp = characterXp;
            CharacterMaxAge = characterMaxAge;
            CharacterMaxLevelXp = characterMaxLevelXp;
            Region = region;
            SkillPoints = skillPoints;
            SkillResetPoints = skillResetPoints;

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

                    Writer.Write(ContentCharacterName.Length);
                    Writer.Write(ContentCharacterName);
                    Writer.Write(CharacterId);
                    Writer.Write(CharacterLevel);
                    Writer.Write(CharacterXp);
                    Writer.Write(CharacterMaxAge);
                    Writer.Write(CharacterMaxLevelXp);
                    Writer.Write(Region);
                    Writer.Write(SkillPoints);
                    Writer.Write(SkillResetPoints);

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
                "PacketBCharacterDetailsPacket\r\n" +
                "CharacterName = {0}\r\n" +
                "CharacterId = {1}\r\n" +
                "CharacterLevel = {2}\r\n" +
                "CharacterXp = {3}\r\n" +
                "CharacterMaxAge = {4}\r\n" +
                "CharacterMaxLevelXp = {5}\r\n" +
                "Region = {6}\r\n" +
                "SkillPoints = {7}\r\n" +
                "SkillResetPoints = {8}",
                CharacterName,
                CharacterId,
                CharacterLevel,
                CharacterXp,
                CharacterMaxAge,
                CharacterMaxLevelXp,
                Region,
                SkillPoints,
                SkillResetPoints
            );

        }

    }

}
