using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBSendBugReport.
    /// </summary>
    public class PacketBSendBugReport
    {

        public byte[] Variable { get; }

        public PacketBSendBugReport(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBSendBugReport\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
