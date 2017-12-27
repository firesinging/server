using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestMarketplaceClaimCoin.
    /// </summary>
    public class PacketBRequestMarketplaceClaimCoin
    {

        public byte[] Variable { get; }

        public PacketBRequestMarketplaceClaimCoin(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestMarketplaceClaimCoin\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
