using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBUpdateResourcesPacket.
    /// </summary>
    public class PacketBUpdateResourcesPacket
    {

        public byte[] Variable { get; }

        public PacketBUpdateResourcesPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBUpdateResourcesPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
