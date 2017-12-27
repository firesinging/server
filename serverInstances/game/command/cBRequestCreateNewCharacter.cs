using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.game;
using Libraries.enums;


namespace Game.Command
{

    public class BRequestCreateNewCharacter : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestCreateNewCharacter Request = new PacketBRequestCreateNewCharacter(p.Content);

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            // @TODO
            // CreateCharacter(Request.Xuid, Request.CivilizationId, Request.CityName, Request.CityScenario, Request.SkipTutorial);
            
            long CharacterId = 0;

            PacketBResponseCreateNewCharacter ResponseContent = new PacketBResponseCreateNewCharacter(Request.Xuid, CharacterId, 0, Request.CivilizationId);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseCreateNewCharacter, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
