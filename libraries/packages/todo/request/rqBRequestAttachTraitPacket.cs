using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestAttachTraitPacket.
    /// </summary>
    public class PacketBRequestAttachTraitPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestAttachTraitPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAttachTraitPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
