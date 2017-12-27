using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestRetrieveScenarioDelta.
    /// </summary>
    public class PacketBRequestRetrieveScenarioDelta
    {

        public byte[] Variable { get; }

        public PacketBRequestRetrieveScenarioDelta(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRetrieveScenarioDelta\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
