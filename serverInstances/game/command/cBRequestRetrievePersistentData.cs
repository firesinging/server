using System.IO;

using SuperSocket.SocketBase.Command;

using Libraries.database;

using Libraries.helpers.package;
using Libraries.helpers.pathing;
using Libraries.helpers.xml;
using Libraries.packages.game;
using Libraries.enums;


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

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            _SendResponseCharacterInit(s, p, Request);
            _SendResponseCharacterDetails(s, p, Request);

            _SendResponseStringListProtoUnits(s, p, Request);
            _SendResponseStringListDesignsLearned(s, p, Request);
            _SendResponseStringListTechsActive(s, p, Request);
            _SendResponseStringListTechsCapital(s, p, Request);
            _SendResponseStringListTraits(s, p, Request);
            _SendResponseStringListQuestsCompleted(s, p, Request);
            _SendResponseStringListQuests(s, p, Request);
            _SendResponseStringListCapitalResources(s, p, Request);
            _SendResponseStringListRegions(s, p, Request);
            _SendResponseStringListRegionsUnlocked(s, p, Request);
            _SendResponseStringListAdvisorsAvailable(s, p, Request);
            _SendResponseStringListAdvisorsAssigned(s, p, Request);
            _SendResponseStringListCharacterConfig(s, p, Request);
            _SendResponseStringListCraftSchools(s, p, Request);
            _SendResponseStringListVendorKickbacks(s, p, Request);
            _SendResponseStringListVanities(s, p, Request);

            _SendGameCurrency(s, p, Request);

            _SendCharacterPersistenceDone(s, p, Request);


            /*    
         
            @TODO:
            QuestGivers = 8,
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
        private static void _SendResponseCharacterInit(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            PacketBCharacterInitPacket ResponseContent = new PacketBCharacterInitPacket(s.CharacterName, string.Empty, s.CharacterFlags, r.CharacterId, r.Xuid, s.CharacterCivilizationId);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

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
        private static void _SendResponseCharacterDetails(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            PacketBCharacterDetailsPacket ResponseContent = new PacketBCharacterDetailsPacket(s.CharacterName, r.CharacterId, s.CharacterLevel, s.CharacterXp, s.CharacterMaxAge, s.CharacterMaxLevelXp, s.Region, s.SkillPoints, s.SkillResetPoints);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

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
        private static void _SendResponseStringListProtoUnits(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListProtoUnitsResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.ProtoUnits, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for designs learned.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListDesignsLearned(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListDesignsLearnedResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.DesignsLearned, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for techs active.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListTechsActive(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListTechsActiveResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.TechsActive, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for techs capital.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListTechsCapital(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListTechsCapitalResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.TechsCapital, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for traits.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListTraits(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListTraitsResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Traits, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for quests completed.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListQuestsCompleted(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListQuestsCompletedResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.QuestsCompleted, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for quests.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListQuests(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListQuestsResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Quests, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for capital resources.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListCapitalResources(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListCapitalResourcesResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CapitalResources, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for regions.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListRegions(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListRegionsResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Regions, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);            

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for regions unlocked.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListRegionsUnlocked(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListRegionsUnlockedResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.RegionsUnlocked, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for advisors available.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListAdvisorsAvailable(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListAdvisorsAvailableResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.AdvisorsAvailable, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for advisors assigned.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListAdvisorsAssigned(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListAdvisorsAssignedResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.AdvisorsAssigned, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for character config.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListCharacterConfig(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListCharacterConfigResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CharacterConfig, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for craft schools.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListCraftSchools(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListCraftSchoolsResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.CraftSchools, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for vendor kickbacks.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListVendorKickbacks(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListVendorKickbacksResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.VendorKickbacks, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterStringListPacket for vanities.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseStringListVanities(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BCharacterStringListVanitiesResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBCharacterStringListPacket ResponseContent = new PacketBCharacterStringListPacket(StringListTypes.Vanities, r.CharacterId, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterStringListPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BGameCurrencyPacket for game currencies.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendGameCurrency(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BGameCurrencyPacketGameCurrencyResponse.xml");

            if (string.IsNullOrEmpty(Content))
            {

                return;

            }

            PacketBGameCurrencyPacket ResponseContent = new PacketBGameCurrencyPacket(Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BGameCurrencyPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BCharacterPersistenceDone.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendCharacterPersistenceDone(Session s, Package p, PacketBRequestRetrievePersistentData r)
        {

            PacketBCharacterPersistenceDone ResponseContent = new PacketBCharacterPersistenceDone(r.CharacterId);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BCharacterPersistenceDone, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }





    }

}
