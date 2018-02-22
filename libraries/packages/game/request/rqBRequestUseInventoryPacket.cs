using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestUseInventoryPacket.
    /// </summary>
    public class PacketBRequestUseInventoryPacket
    {

        public int Index { get; }

        public PacketBRequestUseInventoryPacket(byte[] request)
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
               "PacketBRequestUseInventoryPacket\r\n" +
               "Index = {0}\r\n",
               Index
           );

        }

    }

}
