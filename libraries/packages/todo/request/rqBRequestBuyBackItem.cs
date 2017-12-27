using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestBuyBackItem.
    /// </summary>
    public class PacketBRequestBuyBackItem
    {

        public byte[] Variable { get; }

        public PacketBRequestBuyBackItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestBuyBackItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
