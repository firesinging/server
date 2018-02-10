using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;

using Libraries.enums;
using Libraries.player;
using Libraries.empire;
using Libraries.character;

using Libraries.helpers.pathing;
using Libraries.helpers.database;
using Libraries.helpers.xml;
using Libraries.database.models;


namespace Libraries.database
{

    public static class Database
    {

        public static readonly bool Instance = false;

        public static readonly Dictionary<int, ModelCharacterLevel> CharacterLevels = new Dictionary<int, ModelCharacterLevel>();        
        public static readonly Dictionary<int, ModelEquipment> Equipments = new Dictionary<int, ModelEquipment>();
        public static readonly Dictionary<int, ModelQuest> Quests = new Dictionary<int, ModelQuest>();

        public static readonly Dictionary<string, ModelAdvisor> Advisors = new Dictionary<string, ModelAdvisor>();
        public static readonly Dictionary<string, ModelBlueprint> Blueprints = new Dictionary<string, ModelBlueprint>();
        public static readonly Dictionary<string, ModelConsumable> Consumables = new Dictionary<string, ModelConsumable>();
        public static readonly Dictionary<string, ModelDesign> Designs = new Dictionary<string, ModelDesign>();        
        public static readonly Dictionary<string, ModelCraftschool> Craftschools = new Dictionary<string, ModelCraftschool>();
        public static readonly Dictionary<string, ModelMaterial> Materials = new Dictionary<string, ModelMaterial>();
        public static readonly Dictionary<string, ModelVendor> Vendors = new Dictionary<string, ModelVendor>();
        public static readonly Dictionary<string, ModelQuestgiver> Questgivers = new Dictionary<string, ModelQuestgiver>();
        public static readonly Dictionary<string, ModelLootRoll> LootRolls = new Dictionary<string, ModelLootRoll>();
        public static readonly Dictionary<string, ModelTrait> Traits = new Dictionary<string, ModelTrait>();

        public static readonly Dictionary<Civilizations, ModelCivilization> Civilizations = new Dictionary<Civilizations, ModelCivilization>();

        public static readonly SerDictionaryRegions<int, ModelRegion> Regions = new SerDictionaryRegions<int, ModelRegion>();

        public static Players Players = new Players();
        public static Empires Empires = new Empires();
        public static Characters Characters = new Characters();

        static Database()
        {

            if (!Instance)
            {                             

                CharacterLevels = DatabaseHelper.Deserialize<ModelCharacterLevels>("CharacterLevels.xml").Items;
                Blueprints = DatabaseHelper.Deserialize<ModelBlueprints>("EconBlueprints.xml").Items;
                Advisors = DatabaseHelper.Deserialize<ModelAdvisors>("advisors.xml").Items;
                Materials = DatabaseHelper.Deserialize<ModelMaterials>("econmaterials.xml").Items;
                Consumables = DatabaseHelper.Deserialize<ModelConsumables>("EconConsumables.xml").Items;
                Designs = DatabaseHelper.Deserialize<ModelDesigns>("EconDesigns.xml").Items;
                Craftschools = DatabaseHelper.Deserialize<ModelCraftschools>("craftschools.xml").Items;
                Vendors = DatabaseHelper.Deserialize<ModelVendors>("EconVendors.xml").Items;
                LootRolls = DatabaseHelper.Deserialize<ModelLootRolls>("econLootRolls.xml").Items;
                Questgivers = DatabaseHelper.Deserialize<ModelQuestgivers>("questgivers.xml").Items;
                Equipments = DatabaseHelper.Deserialize<ModelEquipments>("equipment.xml").Items;

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

                    ModelTrait Trait = new ModelTrait().DeserializeFromFile(TraitFile);

                    Trait.Source = TraitFile;

                    Traits.Add(Trait.Name, Trait);
                    
                }

                foreach (string RegionFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}regions", "*.region", SearchOption.TopDirectoryOnly))
                {

                    ModelRegion Region = new ModelRegion().DeserializeFromFile(RegionFile);

                    Region.Source = RegionFile;

                    Regions.Add(Region.Id, Region);

                }

                foreach (string QuestFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}quests", "*.quest", SearchOption.AllDirectories))
                {

                    ModelQuest Quest = new ModelQuest().DeserializeFromFile(QuestFile);

                    Quest.Source = QuestFile;

                    Quests.Add(Quest.Id, Quest);

                }

                Instance = true;

            }            

        }

        

    }

}
