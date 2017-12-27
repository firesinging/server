using System.IO;
using System.Text;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 0.
    /// </summary>
    public class PacketBResponseRetrieveOptions
    {

        public byte Unk0 { get; }
        public string PlayerSettings { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="unk0">Unkown.</param>
        /// <param name="settings">The settings content.</param>
        public PacketBResponseRetrieveOptions(byte unk0, string settings)
        {

            Unk0 = unk0;
            PlayerSettings = settings;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (MemoryStream Stream = new MemoryStream())
            {

                using (BinaryWriter Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    byte[] Content = Encoding.Unicode.GetBytes(PlayerSettings);
                    byte[] ContentProtected = PackageZipProtection.Compress(Content);

                    int InputSize = Content.Length;
                    int OutputSize = ContentProtected.Length;

                    Writer.Write(Unk0);
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
                "PacketBResponseRetrieveOptions\r\n" +
                "Unk0 = {0}\r\n" +
                "PlayerSettings = {1}\r\n",
                Unk0,
                PlayerSettings
            );

        }

    }

}
