using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestPvPGameStart.
    /// </summary>
    public class PacketBRequestPvPGameStart
    {

        public byte[] Variable { get; }

        public PacketBRequestPvPGameStart(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestPvPGameStart\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
