using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBDynamicGameConfigsPacket.
    /// </summary>
    public class PacketBDynamicGameConfigsPacket
    {

        public byte[] Variable { get; }

        public PacketBDynamicGameConfigsPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBDynamicGameConfigsPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}