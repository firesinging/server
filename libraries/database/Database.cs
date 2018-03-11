using System;
using System.IO;

using System.Linq;
using System.Configuration;
using System.Collections.Generic;

using Libraries.enums;
using Libraries.player;
using Libraries.empire;
using Libraries.character;
using Libraries.quest;
using Libraries.region;
using Libraries.vendor;
using Libraries.inventory.item;
using Libraries.database.models;
using Libraries.database.models.inventory.item;

using Libraries.helpers.pathing;
using Libraries.helpers.database;
using Libraries.helpers.xml;


namespace Libraries.database
{

    public static class Database
    {

        public static readonly bool Instance = false;

        public static readonly Dictionary<int, ModelLevel> Levels = new Dictionary<int, ModelLevel>();        
        public static readonly Dictionary<int, ModelEquipment> Equipments = new Dictionary<int, ModelEquipment>();
        public static readonly Dictionary<int, Quest> Quests = new Dictionary<int, Quest>();
        public static readonly Dictionary<int, QuestNugget> Nuggets = new Dictionary<int, QuestNugget>();

        public static readonly Dictionary<string, Questgiver> Questgivers = new Dictionary<string, Questgiver>();
        public static readonly Dictionary<string, Vendor> Vendors = new Dictionary<string, Vendor>();
        public static readonly Dictionary<string, Trait> Traits = new Dictionary<string, Trait>();
        public static readonly Dictionary<string, Advisor> Advisors = new Dictionary<string, Advisor>();
        public static readonly Dictionary<string, Blueprint> Blueprints = new Dictionary<string, Blueprint>();
        public static readonly Dictionary<string, Consumable> Consumables = new Dictionary<string, Consumable>();
        public static readonly Dictionary<string, Design> Designs = new Dictionary<string, Design>();
        public static readonly Dictionary<string, Lootroll> Lootrolls = new Dictionary<string, Lootroll>();
        public static readonly Dictionary<string, Material> Materials = new Dictionary<string, Material>();
        public static readonly Dictionary<string, ModelCraftschool> Craftschools = new Dictionary<string, ModelCraftschool>();
        public static readonly Dictionary<string, ModelNuggetLogic> NuggetLogics = new Dictionary<string, ModelNuggetLogic>();

        public static readonly Dictionary<Civilizations, ModelCivilization> Civilizations = new Dictionary<Civilizations, ModelCivilization>();

        public static readonly SerDictionaryRegions<int, ModelRegion> Regions = new SerDictionaryRegions<int, ModelRegion>();

        public static Players Players = new Players();
        public static Empires Empires = new Empires();
        public static Characters Characters = new Characters();

        static Database()
        {

            if (!Instance)
            {                             
                
                Levels = DatabaseHelper.Deserialize<ModelLevels>("CharacterLevels.xml").Items;
                Blueprints = DatabaseHelper.Deserialize<ModelInventoryItemBlueprints>("EconBlueprints.xml").Items;
                Advisors = DatabaseHelper.Deserialize<ModelInventoryItemAdvisors>("advisors.xml").Items;
                Materials = DatabaseHelper.Deserialize<ModelInventoryItemMaterials>("econmaterials.xml").Items;
                Consumables = DatabaseHelper.Deserialize<ModelInventoryItemConsumables>("EconConsumables.xml").Items;
                Designs = DatabaseHelper.Deserialize<ModelInventoryItemDesigns>("EconDesigns.xml").Items;
                Craftschools = DatabaseHelper.Deserialize<ModelCraftschools>("craftschools.xml").Items;
                Vendors = DatabaseHelper.Deserialize<ModelVendors>("EconVendors.xml").Items;
                Lootrolls = DatabaseHelper.Deserialize<ModelInventoryItemLootrolls>("econLootRolls.xml").Items;
                Questgivers = DatabaseHelper.Deserialize<ModelQuestgivers>("questgivers.xml").Items;
                Equipments = DatabaseHelper.Deserialize<ModelEquipments>("equipment.xml").Items;
                Nuggets = DatabaseHelper.Deserialize<ModelNuggets>("nuggets.xml").Items;
                NuggetLogics = DatabaseHelper.Deserialize<ModelNuggetLogics>("nuggetlogics.xml").Items;

                foreach (string CivilizationFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}civilizations", "*.xml", SearchOption.TopDirectoryOnly))
                {

                    ModelCivilization Civilization = new ModelCivilization().DeserializeFromFile(CivilizationFile);

                    Civilization.Source = CivilizationFile;

                    Civilizations.Add(Civilization.CivId, Civilization);

                }

                List<string> ExcludedTraitDirectories = new List<string>();

                ExcludedTraitDirectories.Add("_unused");

                if (Convert.ToInt32(ConfigurationManager.AppSettings["UseLosGear"]) != 1)
                {

                    ExcludedTraitDirectories.Add("_los");

                }

                foreach (string TraitFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}traits", "*.xml", SearchOption.AllDirectories).Where(f => !DatabaseHelper.IsExcluded(ExcludedTraitDirectories, f)))
                {
                    
                    Trait ObjTrait = new Trait().DeserializeFromFile(TraitFile);

                    ObjTrait.Source = TraitFile;

                    Traits.Add(ObjTrait.Name, ObjTrait);
                    
                }

                foreach (string RegionFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}regions", "*.region", SearchOption.TopDirectoryOnly))
                {
                    
                    ModelRegion Region = new ModelRegion().DeserializeFromFile(RegionFile);

                    Region.Source = RegionFile;

                    Regions.Add(Region.Id, Region);
                    
                }

                foreach (string QuestFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}quests", "*.quest", SearchOption.AllDirectories))
                {

                    Quest ObjQuest = new Quest().DeserializeFromFile(QuestFile);

                    ObjQuest.Source = QuestFile.Substring(0, QuestFile.LastIndexOf('.')).Replace($"{PathingHelper.gamedatabaseDir}", string.Empty).ToLower();
                    ObjQuest.Instance = DatabaseHelper.GetQuestInstance(ObjQuest);

                    Quests.Add(ObjQuest.Id, ObjQuest);
                    
                }
                
                Instance = true;

            }            

        }

        



    }

}
