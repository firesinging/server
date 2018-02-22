using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.logger;
using Libraries.packages.chat;

using Libraries.helpers.package;


namespace Chat.command
{

    public class BBotNetBasePacketCustomChatLeaveChannelRequest : CommandBase<Session, PackageChat>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, PackageChat p)
        {

            //@TODO
            /*
            PacketBBotNetBasePacketCustomChatLeaveChannelRequest Request = new PacketBBotNetBasePacketCustomChatLeaveChannelRequest(p.Content);

            Logger.Chat($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            PacketBBotNetBasePacketCustomChatLeaveChannelEvent ResponseContent = new PacketBBotNetBasePacketCustomChatLeaveChannelEvent(Request.ChannelName, s.PlayerName);

            Logger.Chat($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            PackageChat Package = new PackageChat(p.HeaderUnk0, p.HeaderXuid, PacketTypesChat.BBotNetBasePacketCustomChatLeaveChannelEvent, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);
            */

        }

    }

}
