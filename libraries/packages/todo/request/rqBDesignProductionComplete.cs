using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBDesignProductionComplete.
    /// </summary>
    public class PacketBDesignProductionComplete
    {

        public byte[] Variable { get; }

        public PacketBDesignProductionComplete(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBDesignProductionComplete\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
