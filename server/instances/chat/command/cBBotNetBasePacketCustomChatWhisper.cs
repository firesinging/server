using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.logger;
using Libraries.packages.chat;

using Libraries.helpers.package;


namespace Chat.command
{

    public class BBotNetBasePacketCustomChatWhisper : CommandBase<Session, PackageChat>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, PackageChat p)
        {

            PacketBBotNetBasePacketCustomChatWhisper Request = new PacketBBotNetBasePacketCustomChatWhisper(p.Content);

            Logger.Chat($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            //@TODO - Get receiver information and pass to function
            // The function needs the ToPlayer Xuid
            _SendWhisperToReceiver(s, p, Request);

            _SendWhisperSuccessToSender(s, p, Request);

        }

        /// <summary>
        /// Sends BBotNetBasePacketCustomChatWhisperResponse.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet PacketBBotNetBasePacketCustomChatWhisper.</param>
        /// <param name="r">Packet PacketBBotNetBasePacketCustomChatWhisper content.</param>
        private static void _SendWhisperToReceiver(Session s, PackageChat p, PacketBBotNetBasePacketCustomChatWhisper r)
        {

            PacketBBotNetBasePacketCustomChatWhisperResponse ResponseContent = new PacketBBotNetBasePacketCustomChatWhisperResponse(r.ToPlayerName, r.ChatMessage);

            Logger.Chat($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            PackageChat Package = new PackageChat(p.HeaderUnk0, p.HeaderXuid, PacketTypesChat.BBotNetBasePacketCustomChatWhisperResponse, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends EWhisperRecievedEvent.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet PacketBBotNetBasePacketCustomChatWhisper.</param>
        /// <param name="r">Packet PacketBBotNetBasePacketCustomChatWhisper content.</param>
        private static void _SendWhisperSuccessToSender(Session s, PackageChat p, PacketBBotNetBasePacketCustomChatWhisper r)
        {

            //@TODO

            /*
            PacketEWhisperRecievedEvent ResponseContent = new PacketEWhisperRecievedEvent(s.PlayerName, r.ChatMessage);

            Logger.Chat($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            PackageChat Package = new PackageChat(p.HeaderUnk0, p.HeaderXuid, PacketTypesChat.eWhisperRecievedEvent, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);
            */
        }


    }

}
