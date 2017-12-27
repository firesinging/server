using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBModifyTerritoryPacket.
    /// </summary>
    public class PacketBModifyTerritoryPacket
    {

        public byte[] Variable { get; }

        public PacketBModifyTerritoryPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBModifyTerritoryPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
