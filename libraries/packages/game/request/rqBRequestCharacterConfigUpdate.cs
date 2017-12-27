using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestCharacterConfigUpdate.
    /// </summary>
    public class PacketBRequestCharacterConfigUpdate
    {

        public string Config { get; }
        public string Value { get; }

        public PacketBRequestCharacterConfigUpdate(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int ConfigLength = Reader.ReadInt32();

                    Config = Encoding.Unicode.GetString(Reader.ReadBytes(ConfigLength));

                    int ValueLength = Reader.ReadInt32();

                    Value = Encoding.Unicode.GetString(Reader.ReadBytes(ValueLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestCharacterConfigUpdate\r\n",
                "Config = {0}\r\n" +
                "Value = {1}",
                Config,
                Value
            );

        }

    }

}
