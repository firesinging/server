using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestInventoryDataPacket.
    /// </summary>
    public class PacketBRequestInventoryDataPacket
    {

        public byte Unk0 { get; }

        public PacketBRequestInventoryDataPacket(byte[] request)
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
               "PacketBRequestInventoryDataPacket\r\n" +
               "Unk0 = {0}\r\n",
               Unk0
           );

        }

    }

}
