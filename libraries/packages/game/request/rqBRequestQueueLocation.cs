using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestQueueLocation.
    /// </summary>
    public class PacketBRequestQueueLocation
    {

        public byte QueueLocation { get; }

        public PacketBRequestQueueLocation(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    QueueLocation = Reader.ReadByte();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestQueueLocation\r\n" +
                "QueueLocation = {0}\r\n",
                QueueLocation
            );
            
        }

    }

}
