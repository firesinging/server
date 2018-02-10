using SuperSocket.SocketBase.Command;

using Libraries.packages.game;
using Libraries.enums;
using Libraries.logger;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestPopulateVendor : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            var Request = new PacketBRequestPopulateVendor(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            //@TODO



        }

    }

}
