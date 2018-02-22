using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestQuestSaveObjectives.
    /// </summary>
    public class PacketBRequestQuestSaveObjectives
    {

        public int QuestId { get; }

        public byte Type { get; }

        public string Content { get; }

        public PacketBRequestQuestSaveObjectives(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    QuestId = Reader.ReadInt32();

                    int ContentLength = Reader.ReadInt32();

                    Content = Encoding.Unicode.GetString(Reader.ReadBytes(ContentLength));

                    Type = Reader.ReadByte();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestQuestSaveObjectives\r\n",
               "QuestId = {0}\r\n" +
               "Content = {1}\r\n" +
               "Type = {2}",
               QuestId,
               Content,
               Type
           );

        }

    }

}
