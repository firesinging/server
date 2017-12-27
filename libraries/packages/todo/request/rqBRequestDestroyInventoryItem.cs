using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestDestroyInventoryItem.
    /// </summary>
    public class PacketBRequestDestroyInventoryItem
    {

        public byte[] Variable { get; }

        public PacketBRequestDestroyInventoryItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestDestroyInventoryItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
