using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestRemoveTraitPacket.
    /// </summary>
    public class PacketBRequestRemoveTraitPacket
    {

        public int ItemId { get; }

        public string Protounit { get; }

        public PacketBRequestRemoveTraitPacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    ItemId = Reader.ReadInt32();

                    int ProtounitLength = Reader.ReadInt32();

                    Protounit = Encoding.Unicode.GetString(Reader.ReadBytes(ProtounitLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestRemoveTraitPacket\r\n",
               "ItemId = {0}\r\n" +
               "Protounit = {1}",
               ItemId,
               Protounit
           );

        }

    }

}
