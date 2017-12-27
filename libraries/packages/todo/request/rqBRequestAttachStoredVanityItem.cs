using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestAttachStoredVanityItem.
    /// </summary>
    public class PacketBRequestAttachStoredVanityItem
    {

        public byte[] Variable { get; }

        public PacketBRequestAttachStoredVanityItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAttachStoredVanityItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
