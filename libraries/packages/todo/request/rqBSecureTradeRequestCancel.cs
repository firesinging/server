using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBSecureTradeRequestCancel.
    /// </summary>
    public class PacketBSecureTradeRequestCancel
    {

        public byte[] Variable { get; }

        public PacketBSecureTradeRequestCancel(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBSecureTradeRequestCancel\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
