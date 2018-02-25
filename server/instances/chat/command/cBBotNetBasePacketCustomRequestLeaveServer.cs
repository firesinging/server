using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;

using Libraries.logger;
using Libraries.packages.chat;

using Libraries.helpers.package;


namespace Chat.command
{

    public class BBotNetBasePacketCustomRequestLeaveServer : CommandBase<Session, PackageChat>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, PackageChat p)
        {

            PacketBBotNetBasePacketCustomRequestLeaveServer Request = new PacketBBotNetBasePacketCustomRequestLeaveServer(p.Content);

            Logger.Chat($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            s.Close(CloseReason.ClientClosing);

        }

    }

}
