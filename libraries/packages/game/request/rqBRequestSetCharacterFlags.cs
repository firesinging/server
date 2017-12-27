using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestSetCharacterFlags.
    /// </summary>
    public class PacketBRequestSetCharacterFlags
    {

        public long Unk0 { get; }

        public byte Unk1 { get; }

        public PacketBRequestSetCharacterFlags(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Unk0 = Reader.ReadInt64();
                    Unk1 = Reader.ReadByte();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestSetCharacterFlags\r\n" +
               "Unk0 = 0x{0:X}\r\n" +
               "Unk1 = {1}\r\n",
               Unk0,
               Unk1
            );

        }

    }

}
