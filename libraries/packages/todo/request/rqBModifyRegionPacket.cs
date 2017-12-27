using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBModifyRegionPacket.
    /// </summary>
    public class PacketBModifyRegionPacket
    {

        public byte[] Variable { get; }

        public PacketBModifyRegionPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBModifyRegionPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
