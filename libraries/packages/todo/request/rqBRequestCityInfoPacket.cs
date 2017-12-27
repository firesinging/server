using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestCityInfoPacket.
    /// </summary>
    public class PacketBRequestCityInfoPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestCityInfoPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestCityInfoPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
