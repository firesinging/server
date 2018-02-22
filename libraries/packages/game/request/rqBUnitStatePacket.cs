using System.IO;
using System.Text;

using Libraries.helpers.package;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBUnitStatePacket.
    /// </summary>
    public class PacketBUnitStatePacket
    {

        public int Flag { get; }

        public string UnitClientState { get; }
        public string UnitServerState { get; }        

        public PacketBUnitStatePacket(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int UnitClientStateOutputSize = Reader.ReadInt32();
                    int UnitClientStateInputSize = Reader.ReadInt32();

                    byte[] UnitClientStateContent = Reader.ReadBytes(UnitClientStateInputSize);

                    UnitClientState = Encoding.UTF8.GetString(PackageZipProtection.Decompress(UnitClientStateContent));

                    int UnitServerStateOutputSize = Reader.ReadInt32();
                    int UnitServerStateInputSize = Reader.ReadInt32();

                    byte[] UnitServerStateContent = Reader.ReadBytes(UnitServerStateInputSize);

                    UnitServerState = Encoding.UTF8.GetString(PackageZipProtection.Decompress(UnitServerStateContent));

                    Flag = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBUnitStatePacket\r\n",
                "UnitClientState = {0}\r\n" +
                "UnitServerState = {1}\r\n" +
                "Flag = {2}",
                UnitClientState,
                UnitServerState,
                Flag
            );

        }

    }

}
