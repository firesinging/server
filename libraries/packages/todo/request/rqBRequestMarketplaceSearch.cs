using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestMarketplaceSearch.
    /// </summary>
    public class PacketBRequestMarketplaceSearch
    {

        public byte[] Variable { get; }

        public PacketBRequestMarketplaceSearch(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestMarketplaceSearch\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
