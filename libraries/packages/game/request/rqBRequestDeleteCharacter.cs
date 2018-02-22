using System.IO;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestDeleteCharacter.
    /// </summary>
    public class PacketBRequestDeleteCharacter
    {

        public long CharacterId { get; }

        public PacketBRequestDeleteCharacter(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    CharacterId = Reader.ReadInt64();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestDeleteCharacter\r\n" +
               "CharacterId = {0}\r\n",
               CharacterId
           );

        }

    }

}
