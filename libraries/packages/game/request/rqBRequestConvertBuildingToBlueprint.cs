using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestConvertBuildingToBlueprint.
    /// </summary>
    public class PacketBRequestConvertBuildingToBlueprint
    {

        public string Item { get; }

        public PacketBRequestConvertBuildingToBlueprint(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int ItemLength = Reader.ReadInt32();

                    Item = Encoding.Unicode.GetString(Reader.ReadBytes(ItemLength));
                    
                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestConvertBuildingToBlueprint\r\n" +
                "Item = {0}\r\n",
                Item
            );

        }

    }

}
