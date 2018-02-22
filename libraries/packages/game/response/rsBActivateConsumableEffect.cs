using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 112.
    /// </summary>
    public class PacketBActivateConsumableEffect
    {

        public long CharacterId { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="count">Count.</param>
        public PacketBActivateConsumableEffect(long characterId)
        {

            CharacterId = characterId;

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

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBActivateConsumableEffect\r\n" +
                "CharacterId = {0}\r\n",
                CharacterId
            );

        }

    }

}
