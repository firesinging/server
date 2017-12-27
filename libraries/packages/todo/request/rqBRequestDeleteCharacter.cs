using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestDeleteCharacter.
    /// </summary>
    public class PacketBRequestDeleteCharacter
    {

        public byte[] Variable { get; }

        public PacketBRequestDeleteCharacter(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestDeleteCharacter\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
