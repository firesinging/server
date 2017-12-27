using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBUnitStatePacket.
    /// </summary>
    public class PacketBUnitStatePacket
    {

        public byte[] Variable { get; }

        public PacketBUnitStatePacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBUnitStatePacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
