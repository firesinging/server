using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBgmXuidList.
    /// </summary>
    public class PacketBgmXuidList
    {

        public byte[] Variable { get; }

        public PacketBgmXuidList(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBgmXuidList\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
