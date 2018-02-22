using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestPurchaseCurrencyContent.
    /// </summary>
    public class PacketBRequestPurchaseCurrencyContent
    {

        public string Content { get; }

        public PacketBRequestPurchaseCurrencyContent(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int ContentLength = Reader.ReadInt32();
                    Content = Encoding.Unicode.GetString(Reader.ReadBytes(ContentLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestPurchaseCurrencyContent\r\n",
                "Content = {0}",
                Content
            );

        }

    }

}
