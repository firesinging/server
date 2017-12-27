using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 36.
    /// </summary>
    public class PacketBCharacterPersistenceDone
    {

        public long CharacterId { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="characterId">The character id.</param>
        public PacketBCharacterPersistenceDone(long characterId)
        {

            CharacterId = characterId;

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

                    Writer.Write(CharacterId);

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
                "PacketBCharacterPersistenceDone\r\n" +
                "CharacterId = {0}\r\n",
                CharacterId
            );

        }

    }

}
