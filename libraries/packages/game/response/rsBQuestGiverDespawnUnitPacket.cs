using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 60.
    /// </summary>
    public class PacketBQuestGiverDespawnUnitPacket
    {

        public string ProtoName { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="protoname">The quest giver name.</param>
        public PacketBQuestGiverDespawnUnitPacket(string protoname)
        {

            ProtoName = protoname;


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

                    byte[] ContentProtoName = Encoding.Unicode.GetBytes(ProtoName);

                    Writer.Write(ContentProtoName.Length);
                    Writer.Write(ContentProtoName);

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
                "PacketBQuestGiverDespawnUnitPacket\r\n" +
                "ProtoName = {0}\r\n",
                ProtoName
            );

        }

    }

}
