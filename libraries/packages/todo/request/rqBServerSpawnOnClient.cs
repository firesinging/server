using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBServerSpawnOnClient.
    /// </summary>
    public class PacketBServerSpawnOnClient
    {

        public byte[] Variable { get; }

        public PacketBServerSpawnOnClient(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBServerSpawnOnClient\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
