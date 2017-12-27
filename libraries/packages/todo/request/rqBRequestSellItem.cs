using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestSellItem.
    /// </summary>
    public class PacketBRequestSellItem
    {

        public byte[] Variable { get; }

        public PacketBRequestSellItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSellItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
