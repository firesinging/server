using SuperSocket.SocketBase.Command;

using Libraries.player;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestCharacterConfigUpdate : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestCharacterConfigUpdate Request = new PacketBRequestCharacterConfigUpdate(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Player ObjPlayer = s.GetPlayer();

            ObjPlayer.Empire.CurrentCharacter.Configs.Set(Request.Config , Request.Value);

            Logger.Debug($"{p.Key}::ExecuteCommand - Character config updated");

        }

    }

}
