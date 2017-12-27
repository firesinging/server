using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestUnitKillXp.
    /// </summary>
    public class PacketBRequestUnitKillXp
    {

        public byte[] Variable { get; }

        public PacketBRequestUnitKillXp(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestUnitKillXp\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
