using System.IO;
using System.Text;

using Libraries.helpers.general;
using Libraries.enums;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 99.
    /// </summary>
    public class PacketBResponseCreateNewCharacter
    {

        public Civilizations CivilizationId { get; }

        public long CharacterId { get; }
        public long Xuid { get; }

        public byte AutoStart { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="xuid">The Xuid the character should belong to.</param>
        /// <param name="characterId">The character id.</param>
        /// <param name="autoStart">Auto start.</param>
        /// <param name="civilizationId">The civilization id the character should belong to.</param>
        public PacketBResponseCreateNewCharacter(long xuid, long characterId, byte autoStart, Civilizations civilizationId)
        {

            Xuid = xuid;
            CharacterId = characterId;
            AutoStart = autoStart;
            CivilizationId = civilizationId;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (MemoryStream Stream = new MemoryStream())
            {

                using (BinaryWriter Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    Writer.Write(Xuid);
                    Writer.Write(CharacterId);
                    Writer.Write(AutoStart);

                    byte[] CivilizationStr = Encoding.Unicode.GetBytes($"<CivId>{(int)CivilizationId}</CivId>");

                    Writer.Write(CivilizationStr.Length);
                    Writer.Write(CivilizationStr);

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
                "PacketBResponseCreateNewCharacter\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "PlayerId = {1}\r\n" +
                "CharacterId = 0x{2:X}\r\n" +
                "AutoStart = {3}\r\n" +
                "CivilizationId = {4}\r\n",
                Xuid,
                0,
                CharacterId,
                AutoStart,
                CivilizationId
            );
            
        }

    }

}
