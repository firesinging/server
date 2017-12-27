using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBGetMailMessagesRequest.
    /// </summary>
    public class PacketBGetMailMessagesRequest
    {

        public long Unk0 { get; }
        public long Unk1 { get; }
        public long Unk2 { get; }

        public PacketBGetMailMessagesRequest(byte[] request)
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
                "PacketBGetMailMessagesRequest\r\n",
                "Unk0 = {0:X}\r\n" +
                "Unk1 = {1:X}\r\n" +
                "Unk2 = {2:X}",
                Unk0,
                Unk1,
                Unk2
            );

        }

    }

}
