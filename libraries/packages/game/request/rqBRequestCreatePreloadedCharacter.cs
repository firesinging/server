using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestCreatePreloadedCharacter.
    /// </summary>
    public class PacketBRequestCreatePreloadedCharacter
    {

        public long Xuid { get; }

        public byte[] Unk0 { get; }
        public byte[] Unk1 { get; }
        public byte[] Unk2 { get; }

        public PacketBRequestCreatePreloadedCharacter(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();

                    int Unk0Length = Reader.ReadInt32();
                    Unk0 = Reader.ReadBytes(Unk0Length);

                    int Unk1Length = Reader.ReadInt32();
                    Unk1 = Reader.ReadBytes(Unk1Length);

                    int Unk2Length = Reader.ReadInt32();
                    Unk2 = Reader.ReadBytes(Unk2Length);

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestCreatePreloadedCharacter\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "Unk0 = {1}\r\n" +
                "Unk1 = {2}\r\n" +
                "Unk2 = {3}\r\n",
                Xuid,
                Helper.PrintBytes(Unk0),
                Helper.PrintBytes(Unk1),
                Helper.PrintBytes(Unk2)
            );

        }

    }

}
