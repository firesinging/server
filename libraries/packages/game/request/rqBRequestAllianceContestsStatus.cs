using Libraries.helpers.general;


namespace Libraries.packages.game
{

    /// <summary>
    /// Reads content packet PacketBRequestAllianceContestsStatus.
    /// </summary>
    public class PacketBRequestAllianceContestsStatus
    {

        public byte[] Unk0 { get; }

        public PacketBRequestAllianceContestsStatus(byte[] request)
        {

            Unk0 = request;

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestAllianceContestsStatus\r\n",
                Helper.PrintBytes(Unk0)
            );

        }

    }

}
