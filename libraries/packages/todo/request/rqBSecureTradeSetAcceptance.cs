using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBSecureTradeSetAcceptance.
    /// </summary>
    public class PacketBSecureTradeSetAcceptance
    {

        public byte[] Variable { get; }

        public PacketBSecureTradeSetAcceptance(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBSecureTradeSetAcceptance\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
