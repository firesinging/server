using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBMarkMailReadRequest.
    /// </summary>
    public class PacketBMarkMailReadRequest
    {

        public byte[] Variable { get; }

        public PacketBMarkMailReadRequest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBMarkMailReadRequest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
