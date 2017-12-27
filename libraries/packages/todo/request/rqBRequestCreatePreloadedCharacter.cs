using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestCreatePreloadedCharacter.
    /// </summary>
    public class PacketBRequestCreatePreloadedCharacter
    {

        public byte[] Variable { get; }

        public PacketBRequestCreatePreloadedCharacter(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestCreatePreloadedCharacter\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
