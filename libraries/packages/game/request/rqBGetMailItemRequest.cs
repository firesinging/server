using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBGetMailItemRequest.
    /// </summary>
    public class PacketBGetMailItemRequest
    {

        public long Unk0 { get; }
        public long Unk1 { get; }
        public long Unk2 { get; }

        public PacketBGetMailItemRequest(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Unk0 = Reader.ReadInt64();
                    Unk1 = Reader.ReadInt64();
                    Unk2 = Reader.ReadInt64();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBGetMailItemRequest\r\n",
                "Unk0 = {0}\r\n" +
                "Unk1 = {1}\r\n" +
                "Unk2 = {2}",
                Unk0,
                Unk1,
                Unk2
            );

        }

    }

}
