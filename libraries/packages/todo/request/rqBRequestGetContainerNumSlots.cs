using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestGetContainerNumSlots.
    /// </summary>
    public class PacketBRequestGetContainerNumSlots
    {

        public byte[] Variable { get; }

        public PacketBRequestGetContainerNumSlots(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestGetContainerNumSlots\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
