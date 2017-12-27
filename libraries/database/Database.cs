using System.IO;

using Libraries.enums;

using Libraries.helpers.pathing;
using Libraries.database.models;
using Libraries.helpers.xml;



namespace Libraries.database
{

    public static class Database
    {

        public static readonly bool Instance = false;

        public static readonly SerDictionaryCharacterLevels<int, ModelCharacterLevel> CharacterLevels = new SerDictionaryCharacterLevels<int, ModelCharacterLevel>();
        public static readonly SerDictionaryRegions<int, ModelRegion> Regions = new SerDictionaryRegions<int, ModelRegion>();
        public static readonly SerDictionaryCivilizations<Civilizations, ModelCivilization> Civilizations = new SerDictionaryCivilizations<Civilizations, ModelCivilization>();
        public static readonly SerDictionaryEquipments<int, ModelEquipment> Equipments = new SerDictionaryEquipments<int, ModelEquipment>();
        public static readonly SerDictionaryQuests<int, ModelQuest> Quests = new SerDictionaryQuests<int, ModelQuest>();

        public static readonly SerDictionaryAdvisors<string, ModelAdvisor> Advisors = new SerDictionaryAdvisors<string, ModelAdvisor>();
        public static readonly SerDictionaryBlueprints<string, ModelBlueprint> Blueprints = new SerDictionaryBlueprints<string, ModelBlueprint>();
        public static readonly SerDictionaryConsumables<string, ModelConsumable> Consumables = new SerDictionaryConsumables<string, ModelConsumable>();
        public static readonly SerDictionaryDesigns<string, ModelDesign> Designs = new SerDictionaryDesigns<string, ModelDesign>();        
        public static readonly SerDictionaryCraftschools<string, ModelCraftschool> Craftschools = new SerDictionaryCraftschools<string, ModelCraftschool>();
        public static readonly SerDictionaryMaterials<string, ModelMaterial> Materials = new SerDictionaryMaterials<string, ModelMaterial>();
        public static readonly SerDictionaryVendors<string, ModelVendor> Vendors = new SerDictionaryVendors<string, ModelVendor>();
        public static readonly SerDictionaryQuestgivers<string, ModelQuestgiver> Questgivers = new SerDictionaryQuestgivers<string, ModelQuestgiver>();
        public static readonly SerDictionaryLootRolls<string, ModelLootRoll> LootRolls = new SerDictionaryLootRolls<string, ModelLootRoll>();        

        static Database()
        {

            if (!Instance)
            {

                ModelCharacterLevels InstanceCharacterLevels = new ModelCharacterLevels().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}CharacterLevels.xml");

                CharacterLevels = InstanceCharacterLevels.Dictionary;

                ModelBlueprints InstanceBlueprints = new ModelBlueprints().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}EconBlueprints.xml");

                Blueprints = InstanceBlueprints.Dictionary;

                ModelAdvisors InstanceAdvisors = new ModelAdvisors().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}advisors.xml");

                Advisors = InstanceAdvisors.Dictionary;

                ModelMaterials InstanceMaterials = new ModelMaterials().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}econmaterials.xml");

                Materials = InstanceMaterials.Dictionary;

                ModelConsumables InstanceConsumables = new ModelConsumables().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}EconConsumables.xml");

                Consumables = InstanceConsumables.Dictionary;

                ModelDesigns InstanceDesigns = new ModelDesigns().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}EconDesigns.xml");

                Designs = InstanceDesigns.Dictionary;

                ModelCraftschools InstanceCraftschools = new ModelCraftschools().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}craftschools.xml");

                Craftschools = InstanceCraftschools.Dictionary;

                ModelVendors InstanceVendors = new ModelVendors().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}EconVendors.xml");

                Vendors = InstanceVendors.Dictionary;

                ModelLootRolls InstanceLootRolls = new ModelLootRolls().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}econLootRolls.xml");

                LootRolls = InstanceLootRolls.Dictionary;

                ModelQuestgivers InstanceQuestgivers = new ModelQuestgivers().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}questgivers.xml");

                Questgivers = InstanceQuestgivers.Dictionary;

                ModelEquipments InstanceEquipments = new ModelEquipments().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}equipment.xml");

                Equipments = InstanceEquipments.Dictionary;
                
                foreach (string RegionFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}regions", "*.region", SearchOption.TopDirectoryOnly))
                {

                    ModelRegion Region = new ModelRegion().DeserializeFromFile(RegionFile);

                    Region.Source = RegionFile;

                    Regions.Add(Region.Id, Region);

                }

                foreach (string CivilizationFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}civilizations", "*.xml", SearchOption.TopDirectoryOnly))
                {

                    ModelCivilization Civilization = new ModelCivilization().DeserializeFromFile(CivilizationFile);

                    Civilization.Source = CivilizationFile;

                    Civilizations.Add(Civilization.CivId, Civilization);

                }

                foreach (string QuestFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}quests", "*.quest", SearchOption.AllDirectories))
                {

                    ModelQuest Quest = new ModelQuest().DeserializeFromFile(QuestFile);

                    Quest.Source = QuestFile;

                    Quests.Add(Quest.UniqueId, Quest);
                    
                }

                Instance = true;

            }            

        }

    }

}
