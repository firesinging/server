using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestSelectMilestoneReward.
    /// </summary>
    public class PacketBRequestSelectMilestoneReward
    {

        public byte[] Variable { get; }

        public PacketBRequestSelectMilestoneReward(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSelectMilestoneReward\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
