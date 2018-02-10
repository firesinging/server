using SuperSocket.SocketBase.Command;

using Libraries.packages.game;
using Libraries.enums;
using Libraries.player;
using Libraries.logger;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestSetCharacterFlags : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestSetCharacterFlags Request = new PacketBRequestSetCharacterFlags(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            Player Player = s.GetPlayer();

            Player.Empire.CurrentCharacter.Flag = Player.Empire.CurrentCharacter.Flag | Request.Unk0;

            PacketBCharacterFlagsChanged ResponseContent = new PacketBCharacterFlagsChanged(Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Flag);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterFlagsChanged, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
