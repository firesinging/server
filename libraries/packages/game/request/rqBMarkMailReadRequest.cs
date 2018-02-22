using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBMarkMailReadRequest.
    /// </summary>
    public class PacketBMarkMailReadRequest
    {

        public long ItemId { get; }

        public PacketBMarkMailReadRequest(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    ItemId = Reader.ReadInt64();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBMarkMailReadRequest\r\n",
                "ItemId = {0}",
                ItemId
            );

        }

    }

}
