using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestReloadPdlc.
    /// </summary>
    public class PacketBRequestReloadPdlc
    {

        public byte[] Variable { get; }

        public PacketBRequestReloadPdlc(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestReloadPdlc\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
