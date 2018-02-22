using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestNuggetCompletePacket.
    /// </summary>
    public class PacketBRequestNuggetCompletePacket
    {

        public int NuggetId { get; }
        public int QuestId { get; }

        public PacketBRequestNuggetCompletePacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    NuggetId = Reader.ReadInt32();
                    QuestId = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestNuggetCompletePacket\r\n" +
                "NuggetId = {0}\r\n" +
                "QuestId = {1}\r\n",
                NuggetId,
                QuestId
            );

        }

    }

}
