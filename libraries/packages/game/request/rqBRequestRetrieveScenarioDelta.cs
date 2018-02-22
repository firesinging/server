using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestRetrieveScenarioDelta.
    /// </summary>
    public class PacketBRequestRetrieveScenarioDelta
    {

        public long Xuid { get; }
        public long EmpireId { get; }

        public string CityName { get; }

        public PacketBRequestRetrieveScenarioDelta(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();
                    EmpireId = Reader.ReadInt64();

                    int CityNameLength = Reader.ReadInt32();

                    CityName = Encoding.Unicode.GetString(Reader.ReadBytes(CityNameLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestRetrieveScenarioDelta\r\n" +
               "Xuid = 0x{0:X}\r\n" +
               "EmpireId = {1}\r\n" +
               "CityName = {2}\r\n",
               Xuid,
               EmpireId,
               CityName
           );

        }

    }

}
