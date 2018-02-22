using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestDestroyInventoryItem.
    /// </summary>
    public class PacketBRequestDestroyInventoryItem
    {

        public int Index { get; }

        public PacketBRequestDestroyInventoryItem(byte[] request)
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
               "PacketBRequestDestroyInventoryItem\r\n" +
               "Index = {0}\r\n",
               Index
           );

        }

    }

}
