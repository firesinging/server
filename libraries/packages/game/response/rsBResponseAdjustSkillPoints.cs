using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 92.
    /// </summary>
    public class PacketBResponseAdjustSkillPoints
    {

        public byte Result { get; }

        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="id">The id.</param>
        public PacketBResponseAdjustSkillPoints(byte result, int id)
        {

            Result = result;
            Id = id;

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

                    Writer.Write(Result);
                    Writer.Write(Id);

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
                "PacketBResponseAdjustSkillPoints\r\n" +
                "Result = {0}\r\n" +
                "Id = {1}\r\n",
                Result,
                Id
            );

        }

    }

}
