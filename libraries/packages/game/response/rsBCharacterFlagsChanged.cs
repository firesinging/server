using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 42.
    /// </summary>
    public class PacketBCharacterFlagsChanged
    {

        public long CharacterId { get; }
        public long Flags { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="characterId">The character id.</param>
        /// <param name="flags">The flags.</param>
        public PacketBCharacterFlagsChanged(long characterId, long flags)
        {

            CharacterId = characterId;
            Flags = flags;

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

                    Writer.Write(CharacterId);
                    Writer.Write(Flags);

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
                "PacketBCharacterFlagsChanged\r\n" +
                "CharacterId = {0}\r\n" +
                "Flags = {1}",
                CharacterId,
                Flags
            );

        }

    }

}
