using System.IO;
using System.Text;

using Libraries.enums;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestQuestOperation.
    /// </summary>
    public class PacketBRequestQuestOperation
    {

        public int Id { get; }

        public QuestOperationTypes Operation { get; }

        public string Unk1 { get; }
        public string Unk2 { get; }

        public PacketBRequestQuestOperation(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Id = Reader.ReadInt32();
                    Operation = (QuestOperationTypes) Reader.ReadByte();

                    int Unk1Length = Reader.ReadInt32();
                    Unk1 = Encoding.Unicode.GetString(Reader.ReadBytes(Unk1Length));

                    int Unk2Length = Reader.ReadInt32();
                    Unk2 = Encoding.Unicode.GetString(Reader.ReadBytes(Unk2Length));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestQuestOperation\r\n" +
               "Id = {0}\r\n" +
               "Operation = {1}\r\n" +
               "Unk1 = {2}\r\n" +
               "Unk2 = {3}\r\n",
               Id,
               Operation,
               Unk1,
               Unk2
           );

        }

    }

}
