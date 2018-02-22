using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestEmpireInventoryAddItem.
    /// </summary>
    public class PacketBRequestEmpireInventoryAddItem
    {

        public int Index { get; }

        public PacketBRequestEmpireInventoryAddItem(byte[] request)
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
               "PacketBRequestEmpireInventoryAddItem\r\n" +
               "Index = {0}\r\n",
               Index
           );

        }

    }

}
