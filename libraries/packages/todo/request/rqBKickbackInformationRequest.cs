using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBKickbackInformationRequest.
    /// </summary>
    public class PacketBKickbackInformationRequest
    {

        public byte[] Variable { get; }

        public PacketBKickbackInformationRequest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBKickbackInformationRequest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
