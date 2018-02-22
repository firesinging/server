using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBDeleteMailRequest.
    /// </summary>
    public class PacketBDeleteMailRequest
    {

        public long Unk0 { get; }
        public long ItemId { get; }

        public PacketBDeleteMailRequest(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Unk0 = Reader.ReadInt64();
                    ItemId = Reader.ReadInt64();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBDeleteMailRequest\r\n" +
                "Unk0 = {0}\r\n" +
                "ItemId = {1}\r\n",
                Unk0,
                ItemId
            );

        }

    }

}
