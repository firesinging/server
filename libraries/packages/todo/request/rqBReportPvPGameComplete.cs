using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBReportPvPGameComplete.
    /// </summary>
    public class PacketBReportPvPGameComplete
    {

        public byte[] Variable { get; }

        public PacketBReportPvPGameComplete(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBReportPvPGameComplete\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
