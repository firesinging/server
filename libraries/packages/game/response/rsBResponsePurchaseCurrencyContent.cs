using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 187.
    /// </summary>
    public class PacketBResponsePurchaseCurrencyContent
    {

        public byte Result { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="result">The result.</param>
        public PacketBResponsePurchaseCurrencyContent(byte result)
        {

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
                "PacketBResponsePurchaseCurrencyContent\r\n" +
                "Result = {0}\r\n",
                Result
            );

        }

    }

}
