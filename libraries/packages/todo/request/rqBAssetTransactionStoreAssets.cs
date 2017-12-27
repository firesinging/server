using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.todo
{

    /// <summary>
    /// Reads content packet PacketBAssetTransactionStoreAssets.
    /// </summary>
    public class PacketBAssetTransactionStoreAssets
    {

        public byte[] Variable { get; }

        public PacketBAssetTransactionStoreAssets(byte[] request)
        {

            Variable = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBAssetTransactionStoreAssets\r\n",
                Helper.PrintBytes(Variable)
            );

        }

    }

}
