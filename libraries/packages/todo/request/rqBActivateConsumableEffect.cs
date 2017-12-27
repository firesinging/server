using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBActivateConsumableEffect.
    /// </summary>
    public class PacketBActivateConsumableEffect
    {

        public byte[] Variable { get; }

        public PacketBActivateConsumableEffect(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBActivateConsumableEffect\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
