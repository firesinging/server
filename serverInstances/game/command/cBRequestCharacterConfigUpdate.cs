using SuperSocket.SocketBase.Command;

using Libraries.packages.game;
using Libraries.player;
using Libraries.logger;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestCharacterConfigUpdate : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestCharacterConfigUpdate Request = new PacketBRequestCharacterConfigUpdate(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            Player Player = s.GetPlayer();

            Player.Empire.CurrentCharacter.Configs.Set(Request.Config , Request.Value);

        }

    }

}
