using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestAddUnitToRemoveListPacket.
    /// </summary>
    public class PacketBRequestAddUnitToRemoveListPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestAddUnitToRemoveListPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAddUnitToRemoveListPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
