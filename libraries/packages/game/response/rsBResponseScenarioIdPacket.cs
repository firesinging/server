using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 84.
    /// </summary>
    public class PacketBResponseScenarioIdPacket
    {

        public int ScenarioId { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="scenarioId">The scenario id.</param>
        public PacketBResponseScenarioIdPacket(int scenarioId)
        {

            ScenarioId = scenarioId;

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

                    Writer.Write(ScenarioId);

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
                "PacketBResponseScenarioIdPacket\r\n" +
                "ScenarioId = {0}\r\n", 
                ScenarioId
            );

        }

    }

}
