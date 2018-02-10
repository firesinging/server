using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 88.
    /// </summary>
    public class PacketBResponseStoreOptions
    {

        public byte Result { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="result">The result.</param>
        public PacketBResponseStoreOptions(byte result)
        {

            Result = result;
            
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
                "PacketBResponseStoreOptions\r\n" +
                "Result = {0}",
                Result
            );

        }

    }

}
