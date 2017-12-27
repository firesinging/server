using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestEnterRespecMode.
    /// </summary>
    public class PacketBRequestEnterRespecMode
    {

        public byte[] Variable { get; }

        public PacketBRequestEnterRespecMode(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestEnterRespecMode\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
