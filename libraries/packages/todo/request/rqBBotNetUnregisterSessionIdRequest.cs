using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBBotNetUnregisterSessionIdRequest.
    /// </summary>
    public class PacketBBotNetUnregisterSessionIdRequest
    {

        public byte[] Variable { get; }

        public PacketBBotNetUnregisterSessionIdRequest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetUnregisterSessionIdRequest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
