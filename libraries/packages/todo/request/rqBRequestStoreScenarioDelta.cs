using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestStoreScenarioDelta.
    /// </summary>
    public class PacketBRequestStoreScenarioDelta
    {

        public byte[] Variable { get; }

        public PacketBRequestStoreScenarioDelta(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestStoreScenarioDelta\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
