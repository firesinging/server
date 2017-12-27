using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 70.
    /// </summary>
    public class PacketBResponseRequestRegionMap
    {

        public byte CanAccess { get; }

        public string RegionFile { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="request">The request.</param>
        public PacketBResponseRequestRegionMap(byte canAccess, string regionFile)
        {

            CanAccess = canAccess;
            RegionFile = regionFile;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (var Stream = new MemoryStream())
            {

                using (var Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    byte[] RegionFileContent = Encoding.Unicode.GetBytes(RegionFile);

                    Writer.Write(CanAccess);
                    Writer.Write(RegionFileContent.Length);
                    Writer.Write(RegionFileContent);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(
                "PacketBResponseRequestRegionMap\r\n" +
                "CanAccess = {0}\r\n" +
                "RegionFile = {1}\r\n",
                CanAccess,
                RegionFile
            );

        }

    }

}
