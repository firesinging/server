using System;
using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestAndIncrementScenarioIdPacket.
    /// </summary>
    public class PacketBRequestAndIncrementScenarioIdPacket
    {

        public int Increment { get; }

        public PacketBRequestAndIncrementScenarioIdPacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Increment = Convert.ToInt32(Reader.ReadByte());

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAndIncrementScenarioIdPacket\r\n" +
                "Increment = {0}\r\n",
                Increment
            );

        }

    }

}
