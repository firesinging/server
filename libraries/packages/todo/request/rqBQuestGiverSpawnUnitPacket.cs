using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBQuestGiverSpawnUnitPacket.
    /// </summary>
    public class PacketBQuestGiverSpawnUnitPacket
    {

        public byte[] Variable { get; }

        public PacketBQuestGiverSpawnUnitPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBQuestGiverSpawnUnitPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
