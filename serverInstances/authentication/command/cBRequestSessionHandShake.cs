using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.custom;
using Libraries.enums;


namespace Authentication.Command
{

    public class BRequestSessionHandShake : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestSessionHandShake Request = new PacketBRequestSessionHandShake(p.Content);

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            //@TODO validate player
            // Also duplicate on game instance

            PacketBResponseSessionHandShake ResponseContent = new PacketBResponseSessionHandShake(1);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseSessionHandShake, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
