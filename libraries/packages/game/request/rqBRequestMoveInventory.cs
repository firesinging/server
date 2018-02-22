using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestMoveInventory.
    /// </summary>
    public class PacketBRequestMoveInventory
    {

        public int CurrentIndex { get; }
        public int NewIndex { get; }
        public int Unk0 { get; }

        public string CurrentInventory { get; }
        public string NewInventory { get; }        

        public PacketBRequestMoveInventory(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int CurrentInventoryLength = Reader.ReadInt32();

                    CurrentInventory = Encoding.Unicode.GetString(Reader.ReadBytes(CurrentInventoryLength));

                    int NewInventoryLength = Reader.ReadInt32();

                    NewInventory = Encoding.Unicode.GetString(Reader.ReadBytes(NewInventoryLength));

                    CurrentIndex = Reader.ReadInt32();
                    NewIndex = Reader.ReadInt32();
                    Unk0 = Reader.ReadInt32();

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
               "PacketBRequestMoveInventory\r\n" +
               "CurrentInventory = {0}\r\n" +
               "NewInventory = {1}\r\n" +
               "CurrentIndex = {2}\r\n" +
               "NewIndex = {3}\r\n" +
               "Unk0 = {4}\r\n",
               CurrentInventory,
               NewInventory,
               CurrentIndex,
               NewIndex,
               Unk0
           );

        }

    }

}
