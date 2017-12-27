using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestRenameCharacter.
    /// </summary>
    public class PacketBRequestRenameCharacter
    {

        public byte[] Variable { get; }

        public PacketBRequestRenameCharacter(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestRenameCharacter\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
