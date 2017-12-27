using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 57.
    /// </summary>
    public class PacketBResponseCityDataStartPacket
    {

        public int Unk0 { get; }

        public long Xuid { get; }

        public string ScenarioName { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="xuid">The Xuid.</param>
        public PacketBResponseCityDataStartPacket(long xuid, string scenarioName, int unk0)
        {

            Unk0 = unk0;
            Xuid = xuid;
            ScenarioName = scenarioName;            

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

                    byte[] ScenarioNameStr = Encoding.Unicode.GetBytes(ScenarioName);

                    Writer.Write(Xuid);
                    
                    Writer.Write(ScenarioNameStr.Length);
                    Writer.Write(ScenarioNameStr);
                    Writer.Write(Unk0);

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
                "PacketBResponseCityDataStartPacket\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "PlayerId = {1}\r\n" +
                "ScenarioName = {2}\r\n" +
                "Unknown = {3}\r\n",
                Xuid,
                0,
                ScenarioName,
                Unk0
            );
                        
        }

    }

}
