using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestRegionMap.
    /// </summary>
    public class PacketBRequestRegionMap
    {

        public int RegionId { get; }

        public PacketBRequestRegionMap(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    RegionId = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRegionMap\r\n" +
                "RegionId = {0}\r\n",
                RegionId
            );            

        }

    }

}
