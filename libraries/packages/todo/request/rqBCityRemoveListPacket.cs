using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBCityRemoveListPacket.
    /// </summary>
    public class PacketBCityRemoveListPacket
    {

        public byte[] Variable { get; }

        public PacketBCityRemoveListPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBCityRemoveListPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
