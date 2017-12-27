using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestEmpireInventoryAddItem.
    /// </summary>
    public class PacketBRequestEmpireInventoryAddItem
    {

        public byte[] Variable { get; }

        public PacketBRequestEmpireInventoryAddItem(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestEmpireInventoryAddItem\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
