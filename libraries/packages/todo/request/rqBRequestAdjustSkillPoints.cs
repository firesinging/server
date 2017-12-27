using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestAdjustSkillPoints.
    /// </summary>
    public class PacketBRequestAdjustSkillPoints
    {

        public byte[] Variable { get; }

        public PacketBRequestAdjustSkillPoints(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAdjustSkillPoints\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
