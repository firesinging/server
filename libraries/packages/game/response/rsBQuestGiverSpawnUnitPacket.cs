using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 59.
    /// </summary>
    public class PacketBQuestGiverSpawnUnitPacket
    {

        public int Greetingstringid { get; }

        public string ProtoName { get; }
        public string ProtoType { get; }
        public string Xml { get; }        
        public string Greetingsoundset { get; }
        public string Farewellsoundset { get; }
        public string Artset { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="protoname">The protoname.</param>
        /// <param name="prototype">The prototype.</param>
        /// <param name="xml">The xml.</param>
        /// <param name="greetingstringid">The greeting string id.</param>
        /// <param name="greetingsoundset">The greeting soundset.</param>
        /// <param name="farewellsoundset">The farewell soundset.</param>
        /// <param name="artset">The art set.</param>
        public PacketBQuestGiverSpawnUnitPacket(string protoname, string prototype, string xml, int greetingstringid, string greetingsoundset, string farewellsoundset, string artset)
        {

            ProtoName = protoname;
            ProtoType = prototype;
            Xml = xml;
            Greetingstringid = greetingstringid;
            Greetingsoundset = (!string.IsNullOrEmpty(greetingsoundset)) ? greetingsoundset : string.Empty;
            Farewellsoundset = (!string.IsNullOrEmpty(farewellsoundset)) ? farewellsoundset : string.Empty;
            Artset = (!string.IsNullOrEmpty(artset)) ? artset : string.Empty;

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

                    byte[] ContentProtoName = Encoding.Unicode.GetBytes(ProtoName);
                    byte[] ContentProtoType = Encoding.Unicode.GetBytes(ProtoType);
                    byte[] ContentXml = Encoding.Unicode.GetBytes(Xml);
                    byte[] ContentGreetingsoundset = Encoding.Unicode.GetBytes(Greetingsoundset);
                    byte[] ContentFarewellsoundset = Encoding.Unicode.GetBytes(Farewellsoundset);
                    byte[] ContentArtset = Encoding.Unicode.GetBytes(Artset);

                    Writer.Write(ContentProtoName.Length);
                    Writer.Write(ContentProtoName);
                    Writer.Write(ContentProtoType.Length);
                    Writer.Write(ContentProtoType);
                    Writer.Write(ContentXml.Length);
                    Writer.Write(ContentXml);
                    Writer.Write(Greetingstringid);
                    Writer.Write(ContentGreetingsoundset.Length);
                    Writer.Write(ContentGreetingsoundset);
                    Writer.Write(Farewellsoundset.Length);
                    Writer.Write(Farewellsoundset);
                    Writer.Write(ContentArtset.Length);
                    Writer.Write(ContentArtset);

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
                "PacketBQuestGiverSpawnUnitPacket\r\n" +
                "ProtoName = {0}\r\n" +
                "ProtoType = {1}\r\n" +
                "Xml = {2}\r\n" +
                "Greetingstringid = {3}\r\n" +
                "Greetingsoundset = {4}\r\n" +
                "Farewellsoundset = {5}\r\n" +
                "Artset = {6}",
                ProtoName,
                ProtoType,
                Xml,
                Greetingstringid,
                Greetingsoundset,
                Farewellsoundset,
                Artset
            );

        }

    }

}
