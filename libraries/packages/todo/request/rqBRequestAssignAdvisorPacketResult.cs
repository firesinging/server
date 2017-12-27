using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestAssignAdvisorPacketResult.
    /// </summary>
    public class PacketBRequestAssignAdvisorPacketResult
    {

        public byte[] Variable { get; }

        public PacketBRequestAssignAdvisorPacketResult(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAssignAdvisorPacketResult\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
