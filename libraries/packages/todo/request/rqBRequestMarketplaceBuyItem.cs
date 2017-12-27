using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestMarketplaceBuyItem.
    /// </summary>
    public class PacketBRequestMarketplaceBuyItem
    {

        public byte[] Variable { get; }

        public PacketBRequestMarketplaceBuyItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestMarketplaceBuyItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
