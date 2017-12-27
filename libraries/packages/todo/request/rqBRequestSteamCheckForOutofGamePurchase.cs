using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestSteamCheckForOutofGamePurchase.
    /// </summary>
    public class PacketBRequestSteamCheckForOutofGamePurchase
    {

        public byte[] Variable { get; }

        public PacketBRequestSteamCheckForOutofGamePurchase(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSteamCheckForOutofGamePurchase\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
