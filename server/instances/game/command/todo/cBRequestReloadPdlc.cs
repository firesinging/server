using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.game;
using Libraries.enums;
using Libraries.logger;


namespace Game.Command
{

    public class BRequestReloadPdlc : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            var Request = new Libraries.packages.todo.PacketBRequestReloadPdlc(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");





        }

    }

}
