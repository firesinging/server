using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.game;


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

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            //@TODO - Set for character

        }

    }

}
