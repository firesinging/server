using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestSessionTerminatePacket.
    /// </summary>
    public class PacketBRequestSessionTerminatePacket
    {

        public byte Result { get; }

        public PacketBRequestSessionTerminatePacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Result = Reader.ReadByte();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSessionTerminatePacket\r\n" +
                "Result = {0}",
                Result
            );

        }
        
    }

}
