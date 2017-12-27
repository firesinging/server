using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBPlayerAllianceData.
    /// </summary>
    public class PacketBPlayerAllianceData
    {

        public byte[] Variable { get; }

        public PacketBPlayerAllianceData(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBPlayerAllianceData\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
