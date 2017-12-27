using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestUseInventoryPacket.
    /// </summary>
    public class PacketBRequestUseInventoryPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestUseInventoryPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestUseInventoryPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
