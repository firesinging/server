using System.Linq;
using System.Collections.Generic;
using SuperSocket.SocketBase.Command;

using Libraries.database;
using Libraries.enums;
using Libraries.character;
using Libraries.region;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;
using Libraries.helpers.region;
using Libraries.helpers.text;


namespace Game.Command
{

    public class BRequestRegionMap : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestRegionMap Request = new PacketBRequestRegionMap(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Character ObjCharacter = s.Player.Empire.CurrentCharacter;

            ObjCharacter.Currentregion = Request.RegionId;

            ObjCharacter.Save();

            PacketBResponseRequestRegionMap ResponseContent = new PacketBResponseRequestRegionMap(1, (Request.RegionId == 0) ? ObjCharacter.Capscenario : Database.Regions[Request.RegionId].Mapname);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseRequestRegionMap, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

            BRequestRetrievePersistentData.SendResponseCharacterDetails(s, p);

            SendResponseQuestGivers(s, p);

        }

        /// <summary>
        /// Sends all available quest givers for character.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData or BRequestRegionMap.</param>
        public static void SendResponseQuestGivers(Session s, Package p)
        {
            
            Character ObjCharacter = s.Player.Empire.CurrentCharacter;

            int Currentregion = ObjCharacter.Currentregion;
            List<string> ExcludedCivilizations = RegionHelper.FilterQuestgiversbyCivilization(ObjCharacter.CivId);

            foreach (Questgiver ObjQuestgiver in Database.Questgivers.Values.Where(key => (!ExcludedCivilizations.Contains(TextHelper.SubstringFirst(key.Name, "_", true))) && (key.Region == Currentregion || key.Altregion == Currentregion)))
            {

                if (ObjQuestgiver.IsAvailableToAll())
                {

                    BRequestRefreshQuestGiverSpawns.SendResponseGiverSpawn(s, p, ObjQuestgiver);

                }
                else if (ObjCharacter.Questgivers.Items.TryGetValue(ObjQuestgiver.Name, out CharacterQuestgiver ObjCharacterQuestgiver))
                {

                    if (ObjCharacterQuestgiver.IsAvailable())
                    {

                        BRequestRefreshQuestGiverSpawns.SendResponseGiverSpawn(s, p, ObjQuestgiver);

                    }

                }

            }

        }

    }

}
