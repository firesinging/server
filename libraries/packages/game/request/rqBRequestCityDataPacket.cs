using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestCityDataPacket.
    /// </summary>
    public class PacketBRequestCityDataPacket
    {

        public byte Unk0 { get; }

        public PacketBRequestCityDataPacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Unk0 = Reader.ReadByte();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestCityDataPacket\r\n" +
               "Unk0 = {0}\r\n",
               Unk0
           );

        }

    }

}
