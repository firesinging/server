using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBAssetTransactionGetCurrentCount.
    /// </summary>
    public class PacketBAssetTransactionGetCurrentCount
    {

        public long Xuid { get; }

        public PacketBAssetTransactionGetCurrentCount(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();
                    
                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBAssetTransactionGetCurrentCount\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "PlayerId = {1}\r\n",
                Xuid,
                0
            );

        }

    }

}
