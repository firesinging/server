using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestStoreOptions.
    /// </summary>
    public class PacketBRequestStoreOptions
    {

        public byte[] Variable { get; }

        public PacketBRequestStoreOptions(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestStoreOptions\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
