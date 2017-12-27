using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestMoveInventory.
    /// </summary>
    public class PacketBRequestMoveInventory
    {

        public byte[] Variable { get; }

        public PacketBRequestMoveInventory(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestMoveInventory\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
