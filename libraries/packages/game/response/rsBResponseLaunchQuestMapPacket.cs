using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 63.
    /// </summary>
    public class PacketBResponseLaunchQuestMapPacket
    {

        public byte RandomMap { get; }

        public int Id { get; }
        public int NumPlayers { get; }
        public int MapSize { get; }
        public int Seed { get; }        
        public int Level { get; }
        public int Scale { get; }

        public string Map { get; }
        public string MapVariables { get; }
        public string Nuggets { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="id">The quest id.</param>
        /// <param name="randommap">Flag randommap.</param>
        /// <param name="map">The map.</param>
        /// <param name="numPlayers">The number of players.</param>
        /// <param name="mapsize">The map size.</param>
        /// <param name="seed">The seed.</param>
        /// <param name="mapvariables">The map variables.</param>
        /// <param name="nuggetsContent">The nuggets content.</param>
        /// <param name="level">The quest level.</param>
        /// <param name="scale">The quest scale.</param>
        public PacketBResponseLaunchQuestMapPacket(int id, byte randommap, string map, int numPlayers, int mapsize, int seed, string mapvariables, string nuggets, int level, int scale)
        {

            Id = id;
            RandomMap = randommap;
            Map = map;
            NumPlayers = numPlayers;
            MapSize = mapsize;
            Seed = seed;
            MapVariables = mapvariables;
            Nuggets = nuggets;
            Level = level;
            Scale = scale;

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

                    byte[] ContentMap = Encoding.Unicode.GetBytes(Map);
                    byte[] ContentMapVariables = Encoding.Unicode.GetBytes(MapVariables);
                    byte[] ContentNuggets = Encoding.Unicode.GetBytes(Nuggets);

                    Writer.Write(Id);
                    Writer.Write(RandomMap);
                    Writer.Write(ContentMap.Length);
                    Writer.Write(ContentMap);
                    Writer.Write(NumPlayers);
                    Writer.Write(MapSize);
                    Writer.Write(Seed);
                    Writer.Write(ContentMapVariables.Length);
                    Writer.Write(ContentMapVariables);
                    Writer.Write(ContentNuggets.Length);
                    Writer.Write(ContentNuggets);
                    Writer.Write(Level);
                    Writer.Write(Scale);

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
                "PacketBResponseLaunchQuestMapPacket\r\n" +
                "Id = {0}\r\n" +
                "RandomMap = {1}\r\n" +
                "Map = {2}\r\n" +
                "NumPlayers = {3}\r\n" +
                "MapSize = {4}\r\n" +
                "Seed = {5}\r\n" +
                "MapVariables = {6}\r\n" +
                "Nuggets = {7}\r\n" +
                "Level = {8}\r\n" +
                "Scale = {9}",
                Id,
                RandomMap,
                Map,
                NumPlayers,
                MapSize,
                Seed,
                MapVariables,
                Nuggets,
                Level,
                Scale
            );

        }

    }

}
