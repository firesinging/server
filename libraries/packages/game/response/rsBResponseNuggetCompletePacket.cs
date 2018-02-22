using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 80.
    /// </summary>
    public class PacketBResponseNuggetCompletePacket
    {

        public byte Result { get; }

        public int NuggetId { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="nuggetId">The nugget id.</param>
        /// <param name="result">The result.</param>
        public PacketBResponseNuggetCompletePacket(int nuggetId, byte result)
        {

            NuggetId = nuggetId;
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

                    Writer.Write(NuggetId);
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
                "PacketBResponseNuggetCompletePacket\r\n" +
                "NuggetId = {0}\r\n" +
                "Result = {1}\r\n",
                NuggetId,
                Result
            );

        }

    }

}
