using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBDeleteMailRequest.
    /// </summary>
    public class PacketBDeleteMailRequest
    {

        public byte[] Variable { get; }

        public PacketBDeleteMailRequest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBDeleteMailRequest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
