using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBSendMailRequest.
    /// </summary>
    public class PacketBSendMailRequest
    {

        public byte[] Variable { get; }

        public PacketBSendMailRequest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBSendMailRequest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
