using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestConsoleCommand.
    /// </summary>
    public class PacketBRequestConsoleCommand
    {

        public byte[] Variable { get; }

        public PacketBRequestConsoleCommand(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestConsoleCommand\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
