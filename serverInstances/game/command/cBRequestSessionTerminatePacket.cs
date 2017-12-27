using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.game;


namespace Game.Command
{

    public class BRequestSessionTerminatePacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestSessionTerminatePacket Request = new PacketBRequestSessionTerminatePacket(p.Content);

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            // @TODO
            //s.Player.Logout();

            s.Close(CloseReason.ClientClosing);

        }

    }

}