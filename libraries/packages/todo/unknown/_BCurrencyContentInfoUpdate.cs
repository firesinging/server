using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBCurrencyContentInfoUpdate.
    /// </summary>
    public class PacketBCurrencyContentInfoUpdate
    {

        public byte[] Variable { get; }

        public PacketBCurrencyContentInfoUpdate(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBCurrencyContentInfoUpdate\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
