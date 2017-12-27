using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestMarketplaceItemsForCharacterId.
    /// </summary>
    public class PacketBRequestMarketplaceItemsForCharacterId
    {

        public long CharacterId { get; }

        public PacketBRequestMarketplaceItemsForCharacterId(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    CharacterId = Reader.ReadInt64();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBGetEmpireRequest\r\n" +
                "CharacterId = {0}\r\n",
                CharacterId
            );

        }

    }

}
