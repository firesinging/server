using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestStorePersistentData.
    /// </summary>
    public class PacketBRequestStorePersistentData
    {

        public byte[] Variable { get; }

        public PacketBRequestStorePersistentData(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestStorePersistentData\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
