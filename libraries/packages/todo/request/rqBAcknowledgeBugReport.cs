using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBAcknowledgeBugReport.
    /// </summary>
    public class PacketBAcknowledgeBugReport
    {

        public byte[] Variable { get; }

        public PacketBAcknowledgeBugReport(byte[] request)
        {

            Variable = request;

        }        

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBAcknowledgeBugReport\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
