using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.chat;
using Libraries.enums;


namespace Chat.command
{

    public class BBotNetBasePacketReportChat : CommandBase<Session, PackageChat>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, PackageChat p)
        {

            PacketBBotNetBasePacketReportChat Request = new PacketBBotNetBasePacketReportChat(p.Content);

            //@TODO - Create custom chat level to spam only when requested
            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            //@TODO - Follow up

        }

    }

}