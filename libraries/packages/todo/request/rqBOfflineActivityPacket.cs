using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBOfflineActivityPacket.
    /// </summary>
    public class PacketBOfflineActivityPacket
    {

        public byte[] Variable { get; }

        public PacketBOfflineActivityPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBOfflineActivityPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
