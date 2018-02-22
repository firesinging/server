using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestUpdateCharacterGearScore.
    /// </summary>
    public class PacketBRequestUpdateCharacterGearScore
    {

        public int Gearscore { get; }

        public PacketBRequestUpdateCharacterGearScore(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Gearscore = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestUpdateCharacterGearScore\r\n" +
                "Gearscore = {0}\r\n",
                Gearscore
            );

        }

    }

}
