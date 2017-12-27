using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestDesignProduction.
    /// </summary>
    public class PacketBRequestDesignProduction
    {

        public byte[] Variable { get; }

        public PacketBRequestDesignProduction(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestDesignProduction\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
