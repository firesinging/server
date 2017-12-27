using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestPlaceBlueprintPacket.
    /// </summary>
    public class PacketBRequestPlaceBlueprintPacket
    {

        public byte[] Variable { get; }

        public PacketBRequestPlaceBlueprintPacket(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestPlaceBlueprintPacket\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
