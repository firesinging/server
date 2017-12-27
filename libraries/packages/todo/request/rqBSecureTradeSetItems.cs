using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBSecureTradeSetItems.
    /// </summary>
    public class PacketBSecureTradeSetItems
    {

        public byte[] Variable { get; }

        public PacketBSecureTradeSetItems(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBSecureTradeSetItems\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
