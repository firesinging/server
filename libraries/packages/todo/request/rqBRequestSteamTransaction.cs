using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestSteamTransaction.
    /// </summary>
    public class PacketBRequestSteamTransaction
    {

        public byte[] Variable { get; }

        public PacketBRequestSteamTransaction(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSteamTransaction\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
