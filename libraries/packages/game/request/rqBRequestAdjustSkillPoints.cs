using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestAdjustSkillPoints.
    /// </summary>
    public class PacketBRequestAdjustSkillPoints
    {

        public long Xuid { get; }

        public int[] RemoveTechs { get; }
        public int[] AddTechs { get; }

        public PacketBRequestAdjustSkillPoints(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xuid = Reader.ReadInt64();

                    int RemoveTechsLength = Reader.ReadInt32();

                    RemoveTechs = new int[RemoveTechsLength];

                    for (var i = 0; i < RemoveTechsLength; i++)
                    {

                        RemoveTechs[i] = Reader.ReadInt32() / 256;

                    }

                    int AddTechsLength = Reader.ReadInt32();

                    for (var i = 0; i < AddTechsLength; i++)
                    {

                        AddTechs[i] = Reader.ReadInt32() / 256;

                    }

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAdjustSkillPoints\r\n",
                "Xuid = 0x{0:X}\r\n" +
                "RemoveTechs = {1}\r\n" +
                "AddTechs = {2}",
                Xuid,
                string.Join(",", RemoveTechs),
                string.Join(",", AddTechs)
            );

        }

    }

}
