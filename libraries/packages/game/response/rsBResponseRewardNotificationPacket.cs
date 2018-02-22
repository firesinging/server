using System.IO;
using System.Text;


namespace Libraries.packages.game
{

    /// <summary>
    /// Packet type 73.
    /// </summary>
    public class PacketBResponseRewardNotificationPacket
    {

        public byte Notification { get; }

        public int Reward { get; }
        public int Ui0 { get; }
        public int Amount { get; }
        public int Region { get; }

        public string RewardName { get; }
        public string Ui1 { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="reward">The request.</param>
        /// <param name="ui0">The request.</param>
        /// <param name="amount">The request.</param>
        /// <param name="region">The request.</param>
        /// <param name="rewardName">The request.</param>
        /// <param name="ui1">The request.</param>
        /// <param name="notification">The request.</param>
        public PacketBResponseRewardNotificationPacket(int reward, int ui0, int amount, int region, string rewardName, string ui1, byte notification)
        {

            Reward = reward;
            Ui0 = ui0;
            Amount = amount;
            Region = region;
            RewardName = rewardName;
            Ui1 = ui1;
            Notification = notification;

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

                    byte[] ContentRewardName = Encoding.UTF8.GetBytes(RewardName);
                    byte[] ContentUi1 = Encoding.UTF8.GetBytes(Ui1);

                    Writer.Write(Reward);
                    Writer.Write(Ui0);
                    Writer.Write(Amount);
                    Writer.Write(Region);
                    Writer.Write(ContentRewardName.Length);
                    Writer.Write(ContentRewardName);
                    Writer.Write(ContentUi1.Length);
                    Writer.Write(ContentUi1);
                    Writer.Write(Notification);

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
                "PacketBResponseRewardNotificationPacket\r\n" +
                "Reward = {0}\r\n" +
                "Ui0 = {1}\r\n" +
                "Amount = {2}\r\n" +
                "Region = {3}\r\n" +
                "RewardName = {3}\r\n" +
                "Ui1 = {3}\r\n" +
                "Notification = {4}",
                Reward,
                Ui0,
                Amount,
                Region,
                RewardName,
                Ui1,
                Notification
            );

        }

    }

}
