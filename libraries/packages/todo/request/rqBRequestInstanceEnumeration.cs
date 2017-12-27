using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestInstanceEnumeration.
    /// </summary>
    public class PacketBRequestInstanceEnumeration
    {

        public byte[] Variable { get; }

        public PacketBRequestInstanceEnumeration(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestInstanceEnumeration\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
