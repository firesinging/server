using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestUnitKillXp.
    /// </summary>
    public class PacketBRequestUnitKillXp
    {

        public long Xp { get; }

        public int QuestId { get; }

        public PacketBRequestUnitKillXp(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xp = Reader.ReadInt64();
                    QuestId = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBDeleteMailRequest\r\n" +
                "Xp = {0}\r\n" +
                "QuestId = {1}\r\n",
                Xp,
                QuestId
            );

        }

    }

}
