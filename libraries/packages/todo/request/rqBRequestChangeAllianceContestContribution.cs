using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestChangeAllianceContestContribution.
    /// </summary>
    public class PacketBRequestChangeAllianceContestContribution
    {

        public byte[] Variable { get; }

        public PacketBRequestChangeAllianceContestContribution(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestChangeAllianceContestContribution\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
