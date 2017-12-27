using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestConvertBuildingToBlueprint.
    /// </summary>
    public class PacketBRequestConvertBuildingToBlueprint
    {

        public byte[] Variable { get; }

        public PacketBRequestConvertBuildingToBlueprint(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestConvertBuildingToBlueprint\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
