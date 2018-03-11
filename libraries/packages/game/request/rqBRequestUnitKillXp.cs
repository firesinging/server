using System;
using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestUnitKillXp.
    /// </summary>
    public class PacketBRequestUnitKillXp
    {

        public int Xp { get; }
        public int QuestId { get; }

        public PacketBRequestUnitKillXp(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Xp = Convert.ToInt32(Reader.ReadInt64());
                    QuestId = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestUnitKillXp\r\n" +
                "Xp = {0}\r\n" +
                "QuestId = {1}\r\n",
                Xp,
                QuestId
            );

        }

    }

}
