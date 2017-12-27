using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestRefreshOfferStateData.
    /// </summary>
    public class PacketBRequestRefreshOfferStateData
    {

        public byte[] Variable { get; }

        public PacketBRequestRefreshOfferStateData(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRefreshOfferStateData\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
