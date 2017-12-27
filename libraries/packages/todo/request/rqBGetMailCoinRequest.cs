using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBGetMailCoinRequest.
    /// </summary>
    public class PacketBGetMailCoinRequest
    {

        public byte[] Variable { get; }

        public PacketBGetMailCoinRequest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBGetMailCoinRequest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
