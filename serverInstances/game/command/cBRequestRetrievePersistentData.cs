using System;
using System.Linq;
using SuperSocket.SocketBase.Command;

using Libraries.database;
using Libraries.database.models;
using Libraries.player;
using Libraries.packages.game;
using Libraries.enums;
using Libraries.logger;

using Libraries.helpers.package;
using Libraries.helpers.character;
using Libraries.helpers.region;


namespace Game.Command
{

    public class BRequestRetrievePersistentData : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestRetrievePersistentData Request = new PacketBRequestRetrievePersistentData(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            SendResponseCharacterInit(s, p, Request);
            SendResponseCharacterDetails(s, p, Request);

            //SendResponseStringListProtoUnits(s, p, Request);
            //SendResponseStringListDesignsLearned(s, p, Request);
            SendResponseStringListTechsActive(s, p, Request);
            SendResponseStringListTechsCapital(s, p, Request);
            //SendResponseStringListTraits(s, p, Request);
            //SendResponseStringListQuestsCompleted(s, p, Request);            
            //SendResponseStringListCapitalResources(s, p, Request);
            SendResponseStringListRegions(s, p, Request);
            SendResponseStringListRegionsUnlocked(s, p, Request);
            //SendResponseStringListAdvisorsAvailable(s, p, Request);
            //SendResponseStringListAdvisorsAssigned(s, p, Request);
            //SendResponseStringListCharacterConfig(s, p, Request);
            //SendResponseStringListCraftSchools(s, p, Request);
            //SendResponseStringListVanities(s, p, Request);

            SendGameCurrency(s, p, Request);

            SendCharacterPersistenceDone(s, p, Request);

            SendResponseStringListQuestsInstances(s, p, Request);
            SendResponseQuestGivers(s, p, Request);
            SendResponseQuestList(s, p, Request);


            /*    
         
            @TODO:
            Inventory = 9,
            CapitalLockedTiles = 10,
            CraftSchool2 = 20,
            TerritoriesModified = 21,
            Events = 24            
             
            
            
            */

        }

        

        /// <summary>
        /// Sends BCharacterInitPacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseCharacterInit(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            //@TODO
            // Use the real Xuid instead of r.Xuid
            // See issue https://github.com/firesinging/xlive/issues/2

            Player Player = s.GetPlayer();

            Player.Empire.SetLastLaunchedCharacter(r.CharacterId);

            PacketBCharacterInitPacket ResponseContent = new PacketBCharacterInitPacket(Player.Empire.CurrentCharacter.Name, string.Empty, Player.Empire.CurrentCharacter.Flag, Player.Empire.CurrentCharacter.Id, r.Xuid, Player.Empire.CurrentCharacter.CivId);

            Logger.Debug(p.Key + "::SendResponseCharacterInit - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterInitPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterDetailsPacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseCharacterDetails(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            PacketBCharacterDetailsPacket ResponseContent = new PacketBCharacterDetailsPacket(Player.Empire.CurrentCharacter.Name, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Level, Convert.ToInt32(Player.Empire.CurrentCharacter.Resources.GetResource("XP")), Player.Empire.CurrentCharacter.Currentage, CharacterHelper.GetMaximumXPforLevel(Player.Empire.CurrentCharacter.Level), Player.Empire.CurrentCharacter.Currentregion, Convert.ToInt32(Player.Empire.CurrentCharacter.Capitalresources.GetResource("SkillPoints")), Convert.ToInt32(Player.Empire.CurrentCharacter.Capitalresources.GetResource("Skillresetpoints")));

            Logger.Debug(p.Key + "::SendResponseCharacterDetails - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterDetailsPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for protounits.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListProtoUnits(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Protounits.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.ProtoUnits, Player.Empire.CurrentCharacter.Id, string.Join(",", Player.Empire.CurrentCharacter.Protounits.Items));

                Logger.Debug(p.Key + "::SendResponseStringListProtoUnits - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for designs learned.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListDesignsLearned(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Designslearned.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.DesignsLearned, Player.Empire.CurrentCharacter.Id, string.Join(",", Player.Empire.CurrentCharacter.Designslearned.Items));

                Logger.Debug(p.Key + "::SendResponseStringListDesignsLearned - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for techs active.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListTechsActive(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Activetechs.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.TechsActive, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Activetechs.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListTechsActive - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for techs capital.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListTechsCapital(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Capitaltechs.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.TechsCapital, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Capitaltechs.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListTechsCapital - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for traits.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListTraits(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Traits.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Traits, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Traits.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListTraits - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for quests completed.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListQuestsCompleted(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Questcompleted.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.QuestsCompleted, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Questcompleted.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListQuestsCompleted - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for quests instances.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListQuestsInstances(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Questinstances.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Quests, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Questinstances.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListQuests - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for capital resources.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListCapitalResources(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Capitalresources.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CapitalResources, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Capitalresources.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListCapitalResources - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for regions.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListRegions(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            string Content = RegionHelper.GetRegionsXML();

            if (!string.IsNullOrEmpty(Content))
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Regions, Player.Empire.CurrentCharacter.Id, Content);

                Logger.Debug(p.Key + "::SendResponseStringListRegions - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }                        

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for regions unlocked.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListRegionsUnlocked(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Regionsunlocked.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.RegionsUnlocked, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Regionsunlocked.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListRegionsUnlocked - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for advisors available.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListAdvisorsAvailable(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Availableadvisors.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.AdvisorsAvailable, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Availableadvisors.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListAdvisorsAvailable - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for advisors assigned.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListAdvisorsAssigned(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            string[] arr = { Player.Empire.CurrentCharacter.Assignedadvisors.Age1, Player.Empire.CurrentCharacter.Assignedadvisors.Age2, Player.Empire.CurrentCharacter.Assignedadvisors.Age3, Player.Empire.CurrentCharacter.Assignedadvisors.Age4 };

            if (arr.Length > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.AdvisorsAssigned, Player.Empire.CurrentCharacter.Id, string.Join(",", arr.Where(i => !String.IsNullOrEmpty(i))));

                Logger.Debug(p.Key + "::SendResponseStringListAdvisorsAssigned - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }            

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for character config.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListCharacterConfig(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Configs.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CharacterConfig, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Configs.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListCharacterConfig - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for craft schools.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListCraftSchools(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Craftschools.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CraftSchools, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Craftschools.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListCraftSchools - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }        

        /// <summary>
        /// Sends BCharacterStringListPacket for vanities.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseStringListVanities(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Vanities.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Vanities, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Vanities.ToXml);

                Logger.Debug(p.Key + "::SendResponseStringListVanities - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BGameCurrencyPacket for game currencies.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendGameCurrency(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Gamecurrencys.Items.Count > 0)
            {

                PacketBGameCurrencyPacket ResponseContent = new PacketBGameCurrencyPacket(Player.Gamecurrencys.ToXml);

                Logger.Debug(p.Key + "::SendGameCurrency - Execute command: " + ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BGameCurrencyPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }            

        }

        /// <summary>
        /// Sends BCharacterPersistenceDone.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendCharacterPersistenceDone(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            PacketBCharacterPersistenceDone ResponseContent = new PacketBCharacterPersistenceDone(Player.Empire.CurrentCharacter.Id);

            Logger.Debug(p.Key + "::SendCharacterPersistenceDone - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterPersistenceDone, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BQuestGiverSpawnUnitPacket for quest givers.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseQuestGivers(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            if (Player.Empire.CurrentCharacter.Questgivers.Items.Count > 0)
            {

                int Currentregion = Player.Empire.CurrentCharacter.Currentregion;

                foreach (ModelQuestgiver Questgiver in Database.Questgivers.Values.Where(key => (key.Region == Currentregion || key.Altregion == Currentregion)))
                {

                    if (Player.Empire.CurrentCharacter.Questgivers.Items.ContainsKey(Questgiver.Name))
                    {

                        PacketBQuestGiverSpawnUnitPacket ResponseContent = new PacketBQuestGiverSpawnUnitPacket(Questgiver.Name, Questgiver.Placeunittype, Questgiver.ToXml, Questgiver.Greetingstringid, Questgiver.Greetingsoundset, Questgiver.Farewellsoundset, Questgiver.Artset);

                        Logger.Debug(p.Key + "::SendResponseQuestGivers - Execute command: " + ResponseContent);

                        byte[] Response = ResponseContent.ToByteArray();

                        Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BQuestGiverSpawnUnitPacket, p.HeaderRequestId, Response);

                        byte[] ToSend = Package.ToByteArray();

                        s.Send(ToSend, 0, ToSend.Length);

                    }

                }

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for craft schools.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        public static void SendResponseQuestList(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            Player Player = s.GetPlayer();

            /*
            if (Player.Empire.CurrentCharacter.Craftschools.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CraftSchools, Player.Empire.CurrentCharacter.Id, Player.Empire.CurrentCharacter.Craftschools.ToXml);

                Logger.DebugFormat("BRequestRetrievePersistentData::SendResponseStringListCraftSchools - Response: {0}", ResponseContent);

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

    */

        }
    }

}
