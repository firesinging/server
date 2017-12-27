using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBBotNetVersionRequestPacket.
    /// </summary>
    public class PacketBBotNetVersionRequestPacket
    {

        public int VerMajor { get; }
        public int VerMinor { get; }
        public int VerBuild { get; }
        public int VerRevision { get; }
        
        public PacketBBotNetVersionRequestPacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    VerMajor = Reader.ReadInt32();
                    VerMinor = Reader.ReadInt32();
                    VerBuild = Reader.ReadInt32();
                    VerRevision = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetVersionRequestPacket\r\n" +
                "VerMajor = {0}\r\n" +
                "VerMinor = {1}\r\n" +
                "VerBuild = {2}\r\n" +
                "VerRevision = {3}\r\n",
                VerMajor,
                VerMinor,
                VerBuild,
                VerRevision
            );

        }

    }

}
