using System;
using System.IO;
using SuperSocket.SocketBase.Command;

using Libraries.character;
using Libraries.player;
using Libraries.database;
using Libraries.enums;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;
using Libraries.helpers.pathing;
using Libraries.helpers.character;
using Libraries.helpers.xml;


namespace Game.Command
{

    public class BRequestCreateNewCharacter : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestCreateNewCharacter Request = new PacketBRequestCreateNewCharacter(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            string Tutorial = (Request.SkipTutorial == 1) ? "_Tutorial" : "";

            Player ObjPlayer = s.Player;
            Character ObjCharacter = new Character().DeserializeFromFile($"{PathingHelper.playerDir}characters{Path.DirectorySeparatorChar}civ{Enum.GetName(typeof(Civilizations), Request.CivilizationId)}{Path.DirectorySeparatorChar}Default{Tutorial}.xml");

            ObjCharacter.Id = CharacterHelper.generateCharacterId();
            ObjCharacter.PlayerId = ObjPlayer.Id;
            ObjCharacter.Name = Request.CityName;
            ObjCharacter.Capscenario = CharacterHelper.GetRandomCityScenario(Request.CivilizationId);

            //@TODO
            //START TEST

            ObjCharacter.Questinstances.Items.Add(11001, Database.Quests[11001].Instance);

            //END TEST

            ObjCharacter.Save(true);

            PacketBResponseCreateNewCharacter ResponseContent = new PacketBResponseCreateNewCharacter(Request.Xuid, ObjCharacter.Id, 0, Request.CivilizationId);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseCreateNewCharacter, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
