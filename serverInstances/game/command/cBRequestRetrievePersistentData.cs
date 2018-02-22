using System;
using SuperSocket.SocketBase.Command;

using Libraries.database;
using Libraries.player;
using Libraries.enums;
using Libraries.logger;
using Libraries.database.models;
using Libraries.packages.game;

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

            SendResponseCharacterInit(s, p, Request);
            SendResponseCharacterDetails(s, p);

            //SendResponseStringListProtoUnits(s, p);
            //SendResponseStringListDesignsLearned(s, p);
            SendResponseStringListTechsActive(s, p);
            SendResponseStringListTechsCapital(s, p);
            //SendResponseStringListTraits(s, p);
            //SendResponseStringListQuestsCompleted(s, p);            
            //SendResponseStringListCapitalResources(s, p);
            SendResponseStringListRegions(s, p);
            SendResponseStringListRegionsUnlocked(s, p);
            //SendResponseStringListAdvisorsAvailable(s, p);
            SendResponseStringListAdvisorsAssigned(s, p);
            SendResponseStringListCharacterConfig(s, p);
            //SendResponseStringListCraftSchools(s, p);
            //SendResponseStringListVanities(s, p);

            SendGameCurrency(s, p);

            SendCharacterPersistenceDone(s, p);

            SendResponseStringListQuestsInstances(s, p);
            BRequestRegionMap.SendResponseQuestGivers(s, p);
            SendResponseQuestList(s, p);


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

            Player ObjPlayer = s.GetPlayer();

            ObjPlayer.Empire.SetLastLaunchedCharacter(r.CharacterId);

            PacketBCharacterInitPacket ResponseContent = new PacketBCharacterInitPacket(ObjPlayer.Empire.CurrentCharacter.Name, string.Empty, ObjPlayer.Empire.CurrentCharacter.Flag, ObjPlayer.Empire.CurrentCharacter.Id, r.Xuid, ObjPlayer.Empire.CurrentCharacter.CivId);

            Logger.Debug($"{p.Key}::SendResponseCharacterInit - Execute command: {ResponseContent}");

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
        public static void SendResponseCharacterDetails(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            PacketBCharacterDetailsPacket ResponseContent = new PacketBCharacterDetailsPacket(ObjPlayer.Empire.CurrentCharacter.Name, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Level, Convert.ToInt32(ObjPlayer.Empire.CurrentCharacter.Resources.GetResource("XP")), ObjPlayer.Empire.CurrentCharacter.Currentage, CharacterHelper.GetMaximumXPforLevel(ObjPlayer.Empire.CurrentCharacter.Level), ObjPlayer.Empire.CurrentCharacter.Currentregion, Convert.ToInt32(ObjPlayer.Empire.CurrentCharacter.Capitalresources.GetResource("SkillPoints")), Convert.ToInt32(ObjPlayer.Empire.CurrentCharacter.Capitalresources.GetResource("Skillresetpoints")));

            Logger.Debug($"{p.Key}::SendResponseCharacterDetails - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterDetailsPacket, 0, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for protounits.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListProtoUnits(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Protounits.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.ProtoUnits, ObjPlayer.Empire.CurrentCharacter.Id, string.Join(",", ObjPlayer.Empire.CurrentCharacter.Protounits.Items));

                Logger.Debug($"{p.Key}::SendResponseStringListProtoUnits - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for designs learned.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListDesignsLearned(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Designslearned.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.DesignsLearned, ObjPlayer.Empire.CurrentCharacter.Id, string.Join(",", ObjPlayer.Empire.CurrentCharacter.Designslearned.Items));

                Logger.Debug($"{p.Key}::SendResponseStringListDesignsLearned - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for techs active.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListTechsActive(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Activetechs.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.TechsActive, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Activetechs.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListTechsActive - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for techs capital.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListTechsCapital(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Capitaltechs.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.TechsCapital, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Capitaltechs.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListTechsCapital - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for traits.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListTraits(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Traits.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Traits, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Traits.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListTraits - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for quests completed.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListQuestsCompleted(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Questcompleted.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.QuestsCompleted, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Questcompleted.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListQuestsCompleted - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for quests instances.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListQuestsInstances(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Questinstances.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Quests, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Questinstances.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListQuests - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for capital resources.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListCapitalResources(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Capitalresources.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CapitalResources, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Capitalresources.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListCapitalResources - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for regions.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListRegions(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            string Content = RegionHelper.GetRegionsXML();

            if (!string.IsNullOrEmpty(Content))
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Regions, ObjPlayer.Empire.CurrentCharacter.Id, Content);

                Logger.Debug($"{p.Key}::SendResponseStringListRegions - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }                        

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for regions unlocked.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListRegionsUnlocked(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Regionsunlocked.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.RegionsUnlocked, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Regionsunlocked.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListRegionsUnlocked - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for advisors available.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListAdvisorsAvailable(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Availableadvisors.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.AdvisorsAvailable, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Availableadvisors.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListAdvisorsAvailable - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for advisors assigned.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListAdvisorsAssigned(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            string Assignedadvisors = ObjPlayer.Empire.CurrentCharacter.Assignedadvisors.ToCommaString();            

            if (!string.IsNullOrEmpty(Assignedadvisors))
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.AdvisorsAssigned, ObjPlayer.Empire.CurrentCharacter.Id, Assignedadvisors);

                Logger.Debug($"{p.Key}::SendResponseStringListAdvisorsAssigned - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }            

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for character config.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListCharacterConfig(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Configs.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CharacterConfig, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Configs.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListCharacterConfig - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for craft schools.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListCraftSchools(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Craftschools.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CraftSchools, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Craftschools.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListCraftSchools - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }        

        /// <summary>
        /// Sends BCharacterStringListPacket for vanities.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseStringListVanities(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Vanities.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Vanities, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Vanities.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListVanities - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

        }

        /// <summary>
        /// Sends BGameCurrencyPacket for game currencies.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendGameCurrency(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Gamecurrencys.Items.Count > 0)
            {

                PacketBGameCurrencyPacket ResponseContent = new PacketBGameCurrencyPacket(ObjPlayer.Gamecurrencys.ToXml);

                Logger.Debug($"{p.Key}::SendGameCurrency - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BGameCurrencyPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }            

        }

        /// <summary>
        /// Sends BCharacterPersistenceDone.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendCharacterPersistenceDone(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            PacketBCharacterPersistenceDone ResponseContent = new PacketBCharacterPersistenceDone(ObjPlayer.Empire.CurrentCharacter.Id);

            Logger.Debug($"{p.Key}::SendCharacterPersistenceDone - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterPersistenceDone, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }        

        /// <summary>
        /// Sends BCharacterStringListPacket for craft schools.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        public static void SendResponseQuestList(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            /*
            if (ObjPlayer.Empire.CurrentCharacter.Craftschools.Items.Count > 0)
            {

                PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CraftSchools, ObjPlayer.Empire.CurrentCharacter.Id, ObjPlayer.Empire.CurrentCharacter.Craftschools.ToXml);

                Logger.Debug($"{p.Key}::SendResponseStringListCraftSchools - Execute command: {ResponseContent}");

                byte[] Response = ResponseContent.ToByteArray();

                Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, 0, Response);

                byte[] ToSend = Package.ToByteArray();

                s.Send(ToSend, 0, ToSend.Length);

            }

    */

        }
    }

}
