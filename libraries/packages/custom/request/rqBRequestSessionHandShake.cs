using System.IO;
using System.Text;


namespace Libraries.packages.custom
{

    /// <summary>
    /// Reads content packet BRequestSessionHandShake.
    /// </summary>
    public class PacketBRequestSessionHandShake
    {

        public string PlayerName { get; }
        public string Password { get; }

        /// <summary>
        /// Resolves the package content.
        /// </summary>
        /// <param name="request">The request content.</param>
        public PacketBRequestSessionHandShake(byte[] request)
        {

            using (var Stream = new MemoryStream(request))
            {

                using (var Reader = new BinaryReader(Stream))
                {

                    var PlayerNameLength = Reader.ReadInt32();
                    PlayerName = Encoding.Default.GetString(Reader.ReadBytes(PlayerNameLength));

                    var PasswordLength = Reader.ReadInt32();
                    Password = Encoding.Default.GetString(Reader.ReadBytes(PasswordLength));

                }

            }

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSessionHandShake\r\n" +
                "PlayerName = {0}\r\n" +
                "Password = {1}",
                PlayerName,
                Password
            );

        }

    }

}
