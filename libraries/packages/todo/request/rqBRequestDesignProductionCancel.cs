using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestDesignProductionCancel.
    /// </summary>
    public class PacketBRequestDesignProductionCancel
    {

        public byte[] Variable { get; }

        public PacketBRequestDesignProductionCancel(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestDesignProductionCancel\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
