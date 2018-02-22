using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestPurchaseEmpireInventorySlots.
    /// </summary>
    public class PacketBRequestPurchaseEmpireInventorySlots
    {

        public string Content { get; }

        public PacketBRequestPurchaseEmpireInventorySlots(byte[] request)
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
                "PacketBRequestPurchaseEmpireInventorySlots\r\n",
                "Content = {0}",
                Content
            );

        }

    }

}
