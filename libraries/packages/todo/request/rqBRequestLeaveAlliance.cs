using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestLeaveAlliance.
    /// </summary>
    public class PacketBRequestLeaveAlliance
    {

        public byte[] Variable { get; }

        public PacketBRequestLeaveAlliance(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestLeaveAlliance\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
