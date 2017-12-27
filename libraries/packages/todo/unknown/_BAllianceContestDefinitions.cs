using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBAllianceContestDefinitions.
    /// </summary>
    public class PacketBAllianceContestDefinitions
    {

        public byte[] Variable { get; }

        public PacketBAllianceContestDefinitions(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBAllianceContestDefinitions\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}

