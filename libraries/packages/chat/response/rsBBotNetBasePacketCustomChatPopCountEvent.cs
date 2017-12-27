using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Packet type 9.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatPopCountEvent
    {

        public string ChannelName { get; }
        public int PopCount { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="channelName">The channel name.</param>
        /// <param name="popCount">The current total population count.</param>
        public PacketBBotNetBasePacketCustomChatPopCountEvent(string channelName, int popCount)
        {

            ChannelName = channelName;
            PopCount = popCount;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (MemoryStream Stream = new MemoryStream())
            {

                using (BinaryWriter Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    byte[] contentChannelName = Encoding.Default.GetBytes(ChannelName);

                    Writer.Write(contentChannelName.Length);
                    Writer.Write(contentChannelName);

                    Writer.Write(PopCount);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketCustomChatPopCountEvent\r\n" +
                "ChannelName = {0}\r\n" +
                "PopCount = {1}\r\n",
                ChannelName,
                PopCount
            );

        }

    }

}
