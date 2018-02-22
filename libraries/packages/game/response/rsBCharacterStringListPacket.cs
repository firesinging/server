using System.IO;
using System.Text;

using Libraries.enums;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 35.
    /// </summary>
    public class PacketBCharacterStringListPacket
    {

        public long CharacterId { get; }

        public StringListTypes ListType { get; }

        public string ContentString { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="listType">Reference to the type of content.</param>
        /// <param name="characterId">The character id.</param>
        /// <param name="contentString">The content.</param>
        public PacketBCharacterStringListPacket(StringListTypes listType, long characterId, string contentString)
        {

            CharacterId = characterId;
            ListType = listType;
            ContentString = contentString;

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

                    byte[] Content = Encoding.UTF8.GetBytes(ContentString);
                    byte[] ContentProtected = PackageZipProtection.Compress(Content);

                    int InputSize = Content.Length;
                    int OutputSize = ContentProtected.Length;

                    Writer.Write((int)ListType);
                    Writer.Write(CharacterId);

                    Writer.Write(InputSize);
                    Writer.Write(OutputSize);
                    Writer.Write(ContentProtected);

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
                "PacketBCharacterStringListPacket\r\n" +
                "ListType = {0}\r\n" +
                "CharacterId = {1}\r\n" +
                "ContentString = {2}\r\n",
                ListType,
                CharacterId,
                ContentString
            );

        }

    }

}
