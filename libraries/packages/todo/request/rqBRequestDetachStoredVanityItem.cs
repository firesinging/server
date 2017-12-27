using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestDetachStoredVanityItem.
    /// </summary>
    public class PacketBRequestDetachStoredVanityItem
    {

        public byte[] Variable { get; }

        public PacketBRequestDetachStoredVanityItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestDetachStoredVanityItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
