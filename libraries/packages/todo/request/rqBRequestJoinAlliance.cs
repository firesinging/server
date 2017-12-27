using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestJoinAlliance.
    /// </summary>
    public class PacketBRequestJoinAlliance
    {

        public byte[] Variable { get; }

        public PacketBRequestJoinAlliance(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestJoinAlliance\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
