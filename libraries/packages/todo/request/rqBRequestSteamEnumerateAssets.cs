using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestSteamEnumerateAssets.
    /// </summary>
    public class PacketBRequestSteamEnumerateAssets
    {

        public byte[] Variable { get; }

        public PacketBRequestSteamEnumerateAssets(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSteamEnumerateAssets\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
