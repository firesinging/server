using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestCurrentBonuses.
    /// </summary>
    public class PacketBRequestCurrentBonuses
    {

        public byte[] Variable { get; }

        public PacketBRequestCurrentBonuses(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestCurrentBonuses\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
