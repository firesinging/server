using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 146.
    /// </summary>
    public class PacketBResponseQueueLocation
    {

        public byte Unk0 { get; }

        public short Unk1 { get; }
        public short Unk2 { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="unk0">Unkown.</param>
        /// <param name="unk1">Unkown.</param>
        /// <param name="unk2">Unkown.</param>
        public PacketBResponseQueueLocation(byte unk0, short unk1, short unk2)
        {

            Unk0 = unk0;
            Unk1 = unk1;
            Unk2 = unk2;
            
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

                    Writer.Write(Unk0);
                    Writer.Write(Unk1);
                    Writer.Write(Unk2);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBResponseQueueLocation\r\n" +
                "Unk0 = {0}\r\n" +
                "Unk1 = {1}\r\n" +
                "Unk2 = {2}\r\n",
                Unk0,
                Unk1,
                Unk2
            );

        }

    }

}
