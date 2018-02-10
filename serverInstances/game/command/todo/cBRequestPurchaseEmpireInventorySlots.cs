using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.game;
using Libraries.enums;
using Libraries.logger;


namespace Game.Command
{

    public class BRequestPurchaseEmpireInventorySlots : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            var Request = new Libraries.packages.todo.PacketBRequestPurchaseEmpireInventorySlots(p.Content);

            Logger.DebugFormat("BRequestPurchaseEmpireInventorySlots::ExecuteCommand - Execute command: {0}", Request);





        }

    }

}
