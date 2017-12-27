using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestResetSkillPoints.
    /// </summary>
    public class PacketBRequestResetSkillPoints
    {

        public byte[] Variable { get; }

        public PacketBRequestResetSkillPoints(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestResetSkillPoints\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
