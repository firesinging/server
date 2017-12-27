using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBBotNetRequestPing.
    /// </summary>
    public class PacketBBotNetRequestPing
    {

        public byte[] Variable { get; }

        public PacketBBotNetRequestPing(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetRequestPing\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
