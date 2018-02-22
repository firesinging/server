using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBGetMailCoinRequest.
    /// </summary>
    public class PacketBGetMailCoinRequest
    {

        public long Unk0 { get; }
        public long Unk1 { get; }

        public PacketBGetMailCoinRequest(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Unk0 = Reader.ReadInt64();
                    Unk1 = Reader.ReadInt64();
                    
                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBGetMailCoinRequest\r\n" +
                "Unk0 = {0}\r\n" +
                "Unk1 = {1}\r\n",
                Unk0,
                Unk1
            );

        }

    }

}
