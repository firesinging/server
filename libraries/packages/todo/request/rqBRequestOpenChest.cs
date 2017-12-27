using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestOpenChest.
    /// </summary>
    public class PacketBRequestOpenChest
    {

        public byte[] Variable { get; }

        public PacketBRequestOpenChest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestOpenChest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
