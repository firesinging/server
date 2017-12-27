using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestQuestOperation.
    /// </summary>
    public class PacketBRequestQuestOperation
    {

        public byte[] Variable { get; }

        public PacketBRequestQuestOperation(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestQuestOperation\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
