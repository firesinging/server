using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 115.
    /// </summary>
    public class PacketBResponseGetContainerNumSlots
    {

        public long CharacterId { get; }
        
        public int ContainerTotal { get; }
        public int Unk0 { get; }        

        public string ContainerId { get; }

        public byte Unk1 { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="characterId">The character id.</param>
        /// <param name="containerId">The container id.</param>
        /// <param name="containerTotal">The total number of slots in the container.</param>
        /// <param name="unk0">Unknown.</param>
        /// <param name="unk1">Unknown.</param>
        public PacketBResponseGetContainerNumSlots(long characterId, string containerId, int containerTotal, int unk0, byte unk1)
        {

            CharacterId = characterId;
            ContainerTotal = containerTotal;
            Unk0 = unk0;
            ContainerId = containerId;
            Unk1 = unk1;

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

                    byte[] ContainerIdContent = Encoding.Unicode.GetBytes(ContainerId);

                    Writer.Write(CharacterId);
                    Writer.Write(ContainerIdContent.Length);
                    Writer.Write(ContainerIdContent);
                    Writer.Write(ContainerTotal);
                    Writer.Write(Unk0);
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
                "PacketBResponseGetContainerNumSlots\r\n" +
                "CharacterId = {0}\r\n" +
                "ContainerId = {1}\r\n" +
                "ContainerTotal = {2}\r\n" +
                "Unk0 = {3}\r\n" +
                "Unk1 = {4}",
                CharacterId,
                ContainerId,
                ContainerTotal,
                Unk0,
                Unk1
            );

        }

    }

}
