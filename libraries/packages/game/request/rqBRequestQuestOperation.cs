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

        public string Status { get; }
        public string Unk2 { get; }

        public PacketBRequestQuestOperation(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Id = Reader.ReadInt32();
                    Operation = (QuestOperationTypes) Reader.ReadByte();

                    int StatusLength = Reader.ReadInt32();
                    Status = Encoding.Unicode.GetString(Reader.ReadBytes(StatusLength));

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
               "Status = {2}\r\n" +
               "Unk2 = {3}\r\n",
               Id,
               Operation,
               Status,
               Unk2
           );

        }

    }

}
