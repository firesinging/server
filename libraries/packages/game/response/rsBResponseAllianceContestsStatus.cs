using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 0.
    /// </summary>
    public class PacketBResponseAllianceContestsStatus
    {

        public string PlayerAllianceContestsStatus { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="status">The alliance contests status.</param>
        public PacketBResponseAllianceContestsStatus(string status)
        {

            PlayerAllianceContestsStatus = status;

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

                    byte[] Content = Encoding.Unicode.GetBytes(PlayerAllianceContestsStatus);
                    
                    int InputSize = Content.Length;
                    
                    Writer.Write(InputSize);
                    Writer.Write(Content);

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
                "PacketBResponseAllianceContestsStatus\r\n" +
                "PlayerAllianceContestsStatus = {0}\r\n",
                PlayerAllianceContestsStatus
            );

        }

    }

}
