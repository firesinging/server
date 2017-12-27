using System.IO;

using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestSavedUnitsToServerFirstTime.
    /// </summary>
    public class PacketBRequestSavedUnitsToServerFirstTime
    {

        public byte[] Unk0 { get; }

        public PacketBRequestSavedUnitsToServerFirstTime(byte[] request)
        {

            Unk0 = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestSavedUnitsToServerFirstTime\r\n",
                Helper.PrintBytes(Unk0)
            );

        }

    }

}
