using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestAttachStoredVanityItem.
    /// </summary>
    public class PacketBRequestAttachStoredVanityItem
    {

        public string Vanity { get; }
        public string Protounit { get; }

        public PacketBRequestAttachStoredVanityItem(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int VanityLength = Reader.ReadInt32();

                    Vanity = Encoding.UTF8.GetString(Reader.ReadBytes(VanityLength));

                    int ProtounitLength = Reader.ReadInt32();

                    Protounit = Encoding.UTF8.GetString(Reader.ReadBytes(ProtounitLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetVersionRequestPacket\r\n" +
                "Vanity = {0}\r\n" +
                "Protounit = {1}\r\n",
                Vanity,
                Protounit
            );

        }

    }

}
