using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestUseConsumable.
    /// </summary>
    public class PacketBRequestUseConsumable
    {

        public byte[] Variable { get; }

        public PacketBRequestUseConsumable(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestUseConsumable\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
