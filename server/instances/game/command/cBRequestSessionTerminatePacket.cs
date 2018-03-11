using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;

using Libraries.logger;
using Libraries.player;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestSessionTerminatePacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestSessionTerminatePacket Request = new PacketBRequestSessionTerminatePacket(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Player ObjPlayer = s.Player;

            ObjPlayer.Logout();

            s.Close(CloseReason.ClientClosing);

        }

    }

}