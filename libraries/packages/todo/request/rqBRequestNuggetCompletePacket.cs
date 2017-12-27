using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestNuggetCompletePacket.
    /// </summary>
    public class PacketBRequestNuggetCompletePacket
    {

        public byte[] Variable { get; }

        public PacketBRequestNuggetCompletePacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestNuggetCompletePacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
