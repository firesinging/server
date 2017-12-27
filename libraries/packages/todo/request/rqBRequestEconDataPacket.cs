using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestEconDataPacket.
    /// </summary>
    public class PacketBRequestEconDataPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestEconDataPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestEconDataPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
