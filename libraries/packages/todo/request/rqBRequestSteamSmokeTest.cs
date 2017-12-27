using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestSteamSmokeTest.
    /// </summary>
    public class PacketBRequestSteamSmokeTest
    {

        public byte[] Variable { get; }

        public PacketBRequestSteamSmokeTest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSteamSmokeTest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
