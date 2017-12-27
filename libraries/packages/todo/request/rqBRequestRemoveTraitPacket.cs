using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestRemoveTraitPacket.
    /// </summary>
    public class PacketBRequestRemoveTraitPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestRemoveTraitPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRemoveTraitPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
