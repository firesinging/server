using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 117.
    /// </summary>
    public class PacketBResponseConvertBuildingToBlueprint
    {

        public long CharacterId { get; }

        public byte Result { get; }

        public string Id { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="characterId">The character id.</param>
        /// <param name="id">The protounit id.</param>
        /// <param name="result">The result.</param>
        public PacketBResponseConvertBuildingToBlueprint(long characterId, string id, byte result)
        {

            CharacterId = characterId;
            Id = id;
            Result = result;

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

                    byte[] ContentId = Encoding.Unicode.GetBytes(Id);

                    Writer.Write(CharacterId);
                    Writer.Write(ContentId.Length);
                    Writer.Write(ContentId);
                    Writer.Write(Result);

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
                "PacketBResponseConvertBuildingToBlueprint\r\n" +
                "CharacterId = {0}\r\n" +
                "Id = {1}\r\n" +
                "Result = {2}\r\n",
                CharacterId,
                Id,
                Result
            );

        }

    }

}
