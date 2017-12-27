using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBSecureTradeRequestTrade.
    /// </summary>
    public class PacketBSecureTradeRequestTrade
    {

        public byte[] Variable { get; }

        public PacketBSecureTradeRequestTrade(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBSecureTradeRequestTrade\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
