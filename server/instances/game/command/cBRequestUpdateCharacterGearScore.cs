using SuperSocket.SocketBase.Command;

using Libraries.player;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestUpdateCharacterGearScore : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestUpdateCharacterGearScore Request = new PacketBRequestUpdateCharacterGearScore(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Player ObjPlayer = s.GetPlayer();

            ObjPlayer.Empire.CurrentCharacter.Gearscore = Request.Gearscore;

        }

    }

}
