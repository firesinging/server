using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestBuyItem.
    /// </summary>
    public class PacketBRequestBuyItem
    {

        public byte[] Variable { get; }

        public PacketBRequestBuyItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestBuyItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
