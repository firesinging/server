using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestNewActiveTechPacket.
    /// </summary>
    public class PacketBRequestNewActiveTechPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestNewActiveTechPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestNewActiveTechPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
