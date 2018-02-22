using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 45.
    /// </summary>
    public class PacketBResponseAttachTraitPacket
    {

        public byte Result { get; }

        public int Index { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="result">The result.</param>
        public PacketBResponseAttachTraitPacket(int index, byte result)
        {

            Result = result;
            Index = index;

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

                    Writer.Write(Index);
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
                "PacketBResponseAttachTraitPacket\r\n" +
                "Index = {0}\r\n" +
                "Result = {1}\r\n",
                Index,
                Result
            );

        }

    }

}
