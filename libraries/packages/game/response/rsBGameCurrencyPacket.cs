using System.IO;
using System.Text;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 204.
    /// </summary>
    public class PacketBGameCurrencyPacket
    {

        public string CurrencyContent { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="currencyContent">The currency content.</param>
        public PacketBGameCurrencyPacket(string currencyContent)
        {

            CurrencyContent = currencyContent;

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

                    byte[] Content = Encoding.Unicode.GetBytes(CurrencyContent);
                    byte[] ContentProtected = PackageZipProtection.Compress(Content);

                    int InputSize = Content.Length;
                    int OutputSize = ContentProtected.Length;

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
                "PacketBGameCurrencyPacket\r\n" +
                "CurrencyContent = {0}\r\n",
                CurrencyContent
            );

        }

    }

}
