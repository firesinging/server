using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestChooseCraftSchool.
    /// </summary>
    public class PacketBRequestChooseCraftSchool
    {

        public byte Flag { get; }

        public string Craftschool { get; }        

        public PacketBRequestChooseCraftSchool(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {                    

                    int CraftschoolLength = Reader.ReadInt32();

                    Craftschool = Encoding.UTF8.GetString(Reader.ReadBytes(CraftschoolLength));

                    Flag = Reader.ReadByte();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestChooseCraftSchool\r\n" +
                "Craftschool = {0}\r\n" +
                "Flag = {1}\r\n",
                Craftschool,
                Flag
            );

        }

    }

}
