using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestChooseCraftSchool.
    /// </summary>
    public class PacketBRequestChooseCraftSchool
    {

        public byte[] Variable { get; }

        public PacketBRequestChooseCraftSchool(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestChooseCraftSchool\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
