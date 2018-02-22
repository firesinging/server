using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 143.
    /// </summary>
    public class PacketBNotifyInventoryRemoved
    {

        public string Inventory { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="inventory">The inventory.</param>
        public PacketBNotifyInventoryRemoved(string inventory)
        {

            Inventory = inventory;

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

                    byte[] ContentInventory = Encoding.Unicode.GetBytes(Inventory);

                    Writer.Write(ContentInventory.Length);
                    Writer.Write(ContentInventory);

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
                "PacketBNotifyInventoryRemoved\r\n" +
                "Inventory = {0}\r\n",
                Inventory
            );

        }

    }

}
