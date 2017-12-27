using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestEmpireInventoryRemoveItem.
    /// </summary>
    public class PacketBRequestEmpireInventoryRemoveItem
    {

        public byte[] Variable { get; }

        public PacketBRequestEmpireInventoryRemoveItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestEmpireInventoryRemoveItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
