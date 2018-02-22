using System.IO;
using System.Text;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestStoreScenarioDelta.
    /// </summary>
    public class PacketBRequestStoreScenarioDelta
    {

        public long Xuid { get; }
        public long CharacterId { get; }

        public byte[] ScenarioDelta { get; }

        public string CityName { get; }

        public PacketBRequestStoreScenarioDelta(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();
                    CharacterId = Reader.ReadInt64();

                    int CityNameLength = Reader.ReadInt32();

                    CityName = Encoding.Unicode.GetString(Reader.ReadBytes(CityNameLength));

                    int ScenarioDeltaLength = Reader.ReadInt32();

                    ScenarioDelta = Reader.ReadBytes(ScenarioDeltaLength);

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestStoreScenarioDelta\r\n" +
               "Xuid = 0x{0:X}\r\n" +
               "CharacterId = {1}\r\n" +
               "CityName = {2}\r\n" +
               "ScenarioDelta = {3}\r\n",
               Xuid,
               CharacterId,
               CityName,
               Helper.PrintBytes(ScenarioDelta)
           );

        }

    }

}
