using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestNewTransfer.
    /// </summary>
    public class PacketBRequestNewTransfer
    {

        public byte[] Variable { get; }

        public PacketBRequestNewTransfer(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestNewTransfer\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
