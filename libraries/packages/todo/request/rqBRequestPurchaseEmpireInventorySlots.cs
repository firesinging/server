using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestPurchaseEmpireInventorySlots.
    /// </summary>
    public class PacketBRequestPurchaseEmpireInventorySlots
    {

        public byte[] Variable { get; }

        public PacketBRequestPurchaseEmpireInventorySlots(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestPurchaseEmpireInventorySlots\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
