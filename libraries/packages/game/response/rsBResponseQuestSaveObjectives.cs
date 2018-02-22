using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 34.
    /// </summary>
    public class PacketBResponseQuestSaveObjectives
    {

        public byte Result { get; }

        public int QuestId { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="questId">The quest id.</param>
        /// <param name="result">The result.</param>
        public PacketBResponseQuestSaveObjectives(int questId, byte result)
        {

            QuestId = questId;
            Result = result;

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

                    Writer.Write(QuestId);
                    Writer.Write(Result);

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
                "PacketBResponseQuestSaveObjectives\r\n" +
                "QuestId = {0}\r\n" +
                "Result = {1}\r\n",
                QuestId,
                Result
            );

        }

    }

}
