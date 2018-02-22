using System.IO;
using System.Text;

using Libraries.enums;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 32.
    /// </summary>
    public class PacketBResponseQuestOperation
    {

        public byte Flag { get; }

        public QuestOperationTypes QuestOperation { get; }

        public int Id { get; }       
        public int GiveRegion { get; }
        public int ReturnRegion { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="id">The quest id.</param>
        /// <param name="questOperation">The quest operation.</param>
        /// <param name="flag">Flag.</param>
        /// <param name="giveRegion">The give region.</param>
        /// <param name="returnRegion">The return region.</param>
        public PacketBResponseQuestOperation(int id, QuestOperationTypes questOperation, byte flag, int giveRegion, int returnRegion)
        {

            Id = id;
            QuestOperation = questOperation;
            Flag = flag;
            GiveRegion = giveRegion;
            ReturnRegion = returnRegion;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (var Stream = new MemoryStream())
            {

                using (var Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    byte[] ContentRegions = Encoding.Unicode.GetBytes($"{GiveRegion}|{ReturnRegion}");

                    Writer.Write(Id);
                    Writer.Write((byte) QuestOperation);
                    Writer.Write(Flag);
                    Writer.Write(ContentRegions.Length);
                    Writer.Write(ContentRegions);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(
                "PacketBResponseQuestOperation\r\n" +
                "Id = {0}\r\n" +
                "QuestOperation = {1}\r\n" +
                "Flag = {2}\r\n" +
                "GiveRegion = {3}\r\n" +
                "ReturnRegion = {4}",
                Id,
                QuestOperation,
                Flag,
                GiveRegion,
                ReturnRegion
            );

        }

    }

}
