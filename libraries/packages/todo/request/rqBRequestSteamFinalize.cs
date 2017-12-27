using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestSteamFinalize.
    /// </summary>
    public class PacketBRequestSteamFinalize
    {

        public byte[] Variable { get; }

        public PacketBRequestSteamFinalize(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSteamFinalize\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
