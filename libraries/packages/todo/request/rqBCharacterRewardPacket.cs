using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBCharacterRewardPacket.
    /// </summary>
    public class PacketBCharacterRewardPacket
    {

        public byte[] Variable { get; }

        public PacketBCharacterRewardPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBCharacterRewardPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
