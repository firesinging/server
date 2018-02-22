using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestPlaceBlueprintPacket.
    /// </summary>
    public class PacketBRequestPlaceBlueprintPacket
    {

        public int Index { get; }

        public PacketBRequestPlaceBlueprintPacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Index = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestPlaceBlueprintPacket\r\n",
                "Index = {0}",
                Index
            );

        }

    }

}
