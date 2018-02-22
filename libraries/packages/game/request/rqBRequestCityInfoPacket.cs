using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestCityInfoPacket.
    /// </summary>
    public class PacketBRequestCityInfoPacket
    {

        public long Xuid { get; }

        public PacketBRequestCityInfoPacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestCityInfoPacket\r\n" +
                "Xuid = 0x{0:X}\r\n",
                Xuid
            );

        }

    }

}
