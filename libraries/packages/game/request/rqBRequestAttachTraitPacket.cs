using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestAttachTraitPacket.
    /// </summary>
    public class PacketBRequestAttachTraitPacket
    {

        public int Index { get; }

        public string Protounit { get; }

        public PacketBRequestAttachTraitPacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Index = Reader.ReadInt32();

                    int ProtounitLength = Reader.ReadInt32();

                    Protounit = Encoding.UTF8.GetString(Reader.ReadBytes(ProtounitLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAttachTraitPacket\r\n" +
                "Index = {0}\r\n" +
                "Protounit = {1}\r\n",
                Index,
                Protounit
            );

        }

    }

}
