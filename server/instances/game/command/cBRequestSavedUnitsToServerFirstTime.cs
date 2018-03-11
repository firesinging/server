using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.player;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestSavedUnitsToServerFirstTime : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestSavedUnitsToServerFirstTime Request = new PacketBRequestSavedUnitsToServerFirstTime(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Player ObjPlayer = s.Player;

            ObjPlayer.Empire.CurrentCharacter.Flag = ObjPlayer.Empire.CurrentCharacter.Flag | 0x10;

            PacketBCharacterFlagsChanged ResponseContent = new PacketBCharacterFlagsChanged(ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Flag);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterFlagsChanged, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
