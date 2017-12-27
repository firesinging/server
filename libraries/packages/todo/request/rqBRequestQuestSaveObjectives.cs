using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestQuestSaveObjectives.
    /// </summary>
    public class PacketBRequestQuestSaveObjectives
    {

        public byte[] Variable { get; }

        public PacketBRequestQuestSaveObjectives(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestQuestSaveObjectives\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
