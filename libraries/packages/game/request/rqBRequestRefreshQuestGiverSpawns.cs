using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestRefreshQuestGiverSpawns.
    /// </summary>
    public class PacketBRequestRefreshQuestGiverSpawns
    {

        public string Proto { get; }

        public PacketBRequestRefreshQuestGiverSpawns(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int ProtoLength = Reader.ReadInt32();

                    Proto = Encoding.Unicode.GetString(Reader.ReadBytes(ProtoLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRefreshQuestGiverSpawns\r\n" +
                "Proto = {0}\r\n",
                Proto
            );

        }

    }

}
