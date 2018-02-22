using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 0.
    /// </summary>
    public class PacketBResponsePlaceBlueprintPacket
    {

        public ushort Unk0 { get; }
        public ushort Unk1 { get; }

        public string ProtoName { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="unk0">Unknown.</param>
        /// <param name="protoname">The proto name.</param>
        /// <param name="unk1">Unknown.</param>
        public PacketBResponsePlaceBlueprintPacket(ushort unk0, string protoname, ushort unk1)
        {

            Unk0 = unk0;
            ProtoName = protoname;
            Unk1 = unk1;

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

                    byte[] ContentProtoName = Encoding.UTF8.GetBytes(ProtoName);

                    Writer.Write(Unk0);                   

                    Writer.Write(ContentProtoName.Length);
                    Writer.Write(ContentProtoName);

                    Writer.Write(Unk1);

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
                "PacketBResponsePlaceBlueprintPacket\r\n" +
                "Unk0 = {0}\r\n" +
                "ProtoName = {1}\r\n" +
                "Unk1 = {2}\r\n",
                Unk0,
                ProtoName,
                Unk1
            );

        }

    }

}
