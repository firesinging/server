using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestUpdateCharacterGearScore.
    /// </summary>
    public class PacketBRequestUpdateCharacterGearScore
    {

        public byte[] Variable { get; }

        public PacketBRequestUpdateCharacterGearScore(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestUpdateCharacterGearScore\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
