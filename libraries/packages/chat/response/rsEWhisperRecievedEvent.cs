using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Packet type 7.
    /// </summary>
    public class PacketEWhisperRecievedEvent
    {

        public string FromPlayerName { get; }
        public string ChatMessage { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="fromPlayerName">The sending player name.</param>
        /// <param name="chatMessage">The chat message.</param>
        public PacketEWhisperRecievedEvent(string fromPlayerName, string chatMessage)
        {

            FromPlayerName = fromPlayerName;
            ChatMessage = chatMessage;

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

                    byte[] contentFromPlayerName = Encoding.Default.GetBytes(FromPlayerName);
                    byte[] contentChatMessage = Encoding.Default.GetBytes(ChatMessage);

                    Writer.Write(contentFromPlayerName.Length);
                    Writer.Write(contentFromPlayerName);

                    Writer.Write(contentChatMessage.Length);
                    Writer.Write(contentChatMessage);

                    Package = Stream.ToArray();

                    return Package;

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketEWhisperRecievedEvent\r\n" +
                "FromPlayerName = {0}\r\n" +
                "ChatMessage = {1}\r\n",
                FromPlayerName,
                ChatMessage
            );

        }

    }

}
