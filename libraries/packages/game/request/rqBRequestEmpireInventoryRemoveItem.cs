using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestEmpireInventoryRemoveItem.
    /// </summary>
    public class PacketBRequestEmpireInventoryRemoveItem
    {

        public int Index { get; }

        public PacketBRequestEmpireInventoryRemoveItem(byte[] request)
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
               "PacketBRequestEmpireInventoryRemoveItem\r\n" +
               "Index = {0}\r\n",
               Index
           );

        }

    }

}
