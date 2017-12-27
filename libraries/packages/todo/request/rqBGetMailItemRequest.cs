using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBGetMailItemRequest.
    /// </summary>
    public class PacketBGetMailItemRequest
    {

        public byte[] Variable { get; }

        public PacketBGetMailItemRequest(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBGetMailItemRequest\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
