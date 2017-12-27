using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestAssignAdvisorPacket.
    /// </summary>
    public class PacketBRequestAssignAdvisorPacket
    {

        public string Advisor { get; }

        public PacketBRequestAssignAdvisorPacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int AdvisorLength = Reader.ReadInt32();
                    Advisor = Encoding.Unicode.GetString(Reader.ReadBytes(AdvisorLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAssignAdvisorPacket\r\n" +
                "Advisor = {0}\r\n",
                Advisor
            );

        }

    }

}
