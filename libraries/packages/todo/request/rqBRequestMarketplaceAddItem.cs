using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestMarketplaceAddItem.
    /// </summary>
    public class PacketBRequestMarketplaceAddItem
    {

        public byte[] Variable { get; }

        public PacketBRequestMarketplaceAddItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestMarketplaceAddItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
