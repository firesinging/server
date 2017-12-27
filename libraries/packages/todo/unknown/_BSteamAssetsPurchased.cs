using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBSteamAssetsPurchased.
    /// </summary>
    public class PacketBSteamAssetsPurchased
    {

        public byte[] Variable { get; }

        public PacketBSteamAssetsPurchased(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBSteamAssetsPurchased\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}