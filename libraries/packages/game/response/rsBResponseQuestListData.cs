using System.IO;
using System.Text;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 30.
    /// </summary>
    public class PacketBResponseQuestListData
    {

        public string Xml { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="xml">The quest list xml.</param>
        public PacketBResponseQuestListData(string xml)
        {

            Xml = xml;


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

                    byte[] Content = Encoding.UTF8.GetBytes(Xml);
                    byte[] ContentProtected = PackageZipProtection.Compress(Content);

                    int InputSize = Content.Length;
                    int OutputSize = ContentProtected.Length;

                    Writer.Write(InputSize);
                    Writer.Write(OutputSize);
                    Writer.Write(ContentProtected);

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
                "PacketBResponseQuestListData\r\n" +
                "Response = {0}\r\n",
                Xml
            );

        }

    }

}
