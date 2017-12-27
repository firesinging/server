using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestVisitCityPacket.
    /// </summary>
    public class PacketBRequestVisitCityPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestVisitCityPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestVisitCityPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
