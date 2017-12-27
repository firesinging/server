using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBTransferNotify.
    /// </summary>
    public class PacketBTransferNotify
    {

        public byte[] Variable { get; }

        public PacketBTransferNotify(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBTransferNotify\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}