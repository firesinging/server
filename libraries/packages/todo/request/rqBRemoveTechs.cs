using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRemoveTechs.
    /// </summary>
    public class PacketBRemoveTechs
    {

        public byte[] Variable { get; }

        public PacketBRemoveTechs(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRemoveTechs\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
