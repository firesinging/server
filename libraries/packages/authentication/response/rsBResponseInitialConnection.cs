using System.IO;
using System.Text;


namespace Libraries.packages.authentication
{

    public class PacketBResponseInitialConnection
    {

        public int Response { get; }

        public long Xuid { get; }
        public long Unk0 { get; }
              
        public short Port { get; }

        public string Unk1 { get; }
        public string Unk2 { get; }
        public string Unk3 { get; }
        public string Unk4 { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="Xuid">Xuid from request content.</param>
        /// <param name="Unk0">Unknown.</param>
        /// <param name="Response">Response connection result.</param>
        /// <param name="Unk1">Unknown.</param>
        /// <param name="Unk2">Unknown.</param>
        /// <param name="Port">Response port.</param>
        /// <param name="Unk3">Unknown.</param>
        /// <param name="Unk4">Unknown.</param>
        public PacketBResponseInitialConnection(long xuid, long unk0, int response, string unk1, string unk2, short port, string unk3, string unk4)
        {

            Xuid = xuid;
            Unk0 = unk0;
            Response = response;
            Unk1 = unk1;
            Unk2 = unk2;
            Port = port;
            Unk3 = unk3;
            Unk4 = unk4;

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

                    byte[] Temp1 = Encoding.Unicode.GetBytes(Unk1);
                    byte[] Temp2 = Encoding.Unicode.GetBytes(Unk2);
                    byte[] Temp3 = Encoding.Unicode.GetBytes(Unk3);
                    byte[] Temp4 = Encoding.Unicode.GetBytes(Unk4);

                    Writer.Write(Xuid);
                    Writer.Write(Unk0);

                    Writer.Write((int)Response);

                    Writer.Write(Temp1.Length);
                    Writer.Write(Temp1);

                    Writer.Write(Temp2.Length);
                    Writer.Write(Temp2);

                    Writer.Write(Port);

                    Writer.Write(Temp3.Length);
                    Writer.Write(Temp3);

                    Writer.Write(Temp4.Length);
                    Writer.Write(Temp4);

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
                "PacketBResponseInitialConnection\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "PlayerId = {1}\r\n" +
                "Unk0 = {2}\r\n" +
                "Response = {3}\r\n" +
                "Unk1 = {4}\r\n" +
                "Unk2 = {5}\r\n" +
                "Port = {6}\r\n" +
                "Unk3 = {7}\r\n" +
                "Unk4 = {8}\r\n",
                Xuid,
                0,
                Unk0,
                Response,
                Unk1,
                Unk2,
                Port,
                Unk3,
                Unk4
            );

        }

    }

}
