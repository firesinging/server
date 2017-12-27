using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBMarketplaceNotifySale.
    /// </summary>
    public class PacketBMarketplaceNotifySale
    {

        public byte[] Variable { get; }

        public PacketBMarketplaceNotifySale(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBMarketplaceNotifySale\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
