using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRemoveOneTech.
    /// </summary>
    public class PacketBRemoveOneTech
    {

        public byte[] Variable { get; }

        public PacketBRemoveOneTech(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRemoveOneTech\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
