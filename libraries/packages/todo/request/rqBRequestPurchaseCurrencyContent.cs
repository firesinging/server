using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestPurchaseCurrencyContent.
    /// </summary>
    public class PacketBRequestPurchaseCurrencyContent
    {

        public byte[] Variable { get; }

        public PacketBRequestPurchaseCurrencyContent(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestPurchaseCurrencyContent\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
