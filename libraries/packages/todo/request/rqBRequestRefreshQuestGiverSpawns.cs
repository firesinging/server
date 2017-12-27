using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestRefreshQuestGiverSpawns.
    /// </summary>
    public class PacketBRequestRefreshQuestGiverSpawns
    {

        public byte[] Variable { get; }

        public PacketBRequestRefreshQuestGiverSpawns(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRefreshQuestGiverSpawns\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
