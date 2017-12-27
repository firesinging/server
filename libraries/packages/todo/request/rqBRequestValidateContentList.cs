using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestValidateContentList.
    /// </summary>
    public class PacketBRequestValidateContentList
    {

        public byte[] Variable { get; }

        public PacketBRequestValidateContentList(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestValidateContentList\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
