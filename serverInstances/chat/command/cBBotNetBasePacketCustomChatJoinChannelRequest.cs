using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.chat;
using Libraries.enums;
using Libraries.logger;


namespace Chat.command
{

    public class BBotNetBasePacketCustomChatJoinChannelRequest : CommandBase<Session, PackageChat>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, PackageChat p)
        {

            PacketBBotNetBasePacketCustomChatJoinChannelRequest Request = new PacketBBotNetBasePacketCustomChatJoinChannelRequest(p.Content);

            Logger.Chat(p.Key + "::ExecuteCommand - Execute command: " + Request);

            PacketBBotNetBasePacketCustomChatJoinChannelEvent ResponseContent = new PacketBBotNetBasePacketCustomChatJoinChannelEvent(Request.ChannelName, s.CharacterName);

            Logger.Chat(p.Key + "::ExecuteCommand - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            PackageChat Package = new PackageChat(p.HeaderUnk0, p.HeaderXuid, PacketTypesChat.BBotNetBasePacketCustomChatJoinChannelEvent, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
