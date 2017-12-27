using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBRequestContentLicenseFile.
    /// </summary>
    public class PacketBRequestContentLicenseFile
    {

        public byte[] Variable { get; }

        public PacketBRequestContentLicenseFile(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestContentLicenseFile\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
