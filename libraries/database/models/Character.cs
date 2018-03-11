using System;
using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;
using Libraries.character;
using Libraries.inventory;
using Libraries.database.models.character;


namespace Libraries.database.models
{

    /// <summary>
    /// Character model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Character")]
    public class ModelCharacter : ModelBase
    {

        public ModelCharacter()
        {

            Questcompleted = new ModelQuestCompleted();
            Questinstances = new ModelCharacterQuestinstances();
            Activetechs = new ModelCharacterTechsActive();
            Capitaltechs = new ModelCharacterTechsCapital();
            Protounits = new ModelCharacterProtounits();
            Traits = new ModelCharacterTraits();
            Inventories = new Inventories();
            Capitallockedtiles = new ModelCharacterCapitallockedtiles();
            Questgivers = new ModelCharacterQuestgivers();
            Resources = new CharacterResources();
            Availableadvisors = new ModelCharacterAdvisorsAvailable();
            Assignedadvisors = new AdvisorsAssigned();
            Capitalresources = new CharacterCapitalResources();
            Unitstates = new CharacterUnitstates();
            Configs = new CharacterConfigs();
            Craftschools = new ModelCharacterCraftschools();
            Designslearned = new ModelCharacterLearneddesigns();
            Vanities = new ModelCharacterVanities();
            Regionsunlocked = new ModelCharacterUnlockedRegions();
            
        }
        
        [XmlAttribute(AttributeName = "id")]
        public long Id { get; set; }

        [XmlAttribute(AttributeName = "version")]
        [DefaultValue(1)]
        public int Version { get; set; }
        
        [XmlAttribute(AttributeName = "playerid")]
        public long PlayerId { get; set; }

        [XmlElement(ElementName = "Lastsave")]
        public DateTime Lastsave = DateTime.UtcNow;

        [XmlElement(ElementName = "CivId")]
        public Civilizations CivId { get; set; }

        [XmlElement(ElementName = "capscenario")]
        [DefaultValue(null)]
        public string Capscenario { get; set; }

        [XmlElement(ElementName = "name")]
        [DefaultValue(null)]
        public string Name { get; set; }
        
        [XmlElement(ElementName = "flag")]
        public long Flag { get; set; }

        [XmlElement(ElementName = "level")]
        public int Level { get; set; }

        [XmlElement(ElementName = "gearscore")]
        public int Gearscore { get; set; }

        [XmlElement(ElementName = "currentage")]
        public byte Currentage { get; set; }

        [XmlElement(ElementName = "completedquests")]
        [DefaultValue(null)]
        public ModelQuestCompleted Questcompleted { get; set; }

        [XmlElement(ElementName = "questinstances")]
        public ModelCharacterQuestinstances Questinstances { get; set; }

        [XmlElement(ElementName = "activetechs")]
        public ModelCharacterTechsActive Activetechs { get; set; }

        [XmlElement(ElementName = "capitaltechs")]
        public ModelCharacterTechsCapital Capitaltechs { get; set; }

        [XmlElement(ElementName = "protounits")]
        public ModelCharacterProtounits Protounits { get; set; } 

        [XmlElement(ElementName = "traits")]
        public ModelCharacterTraits Traits { get; set; }

        [XmlElement(ElementName = "inventorycontainers")]
        public Inventories Inventories { get; set; } 

        [XmlElement(ElementName = "capitallockedtiles")]
        public ModelCharacterCapitallockedtiles Capitallockedtiles { get; set; } 

        [XmlElement(ElementName = "questgivers")]
        public ModelCharacterQuestgivers Questgivers { get; set; } 

        [XmlElement(ElementName = "econdesigns")]
        [DefaultValue(null)]
        public string Econdesigns { get; set; }

        [XmlElement(ElementName = "resources")]
        public CharacterResources Resources { get; set; }

        [XmlElement(ElementName = "currentregion")]
        public int Currentregion { get; set; }

        [XmlElement(ElementName = "nextscenarioid")]
        public int Nextscenarioid { get; set; }

        [XmlElement(ElementName = "scenariodelta")]
        public byte[] Scenariodelta { get; set; }

        [XmlElement(ElementName = "availableadvisors")]
        public ModelCharacterAdvisorsAvailable Availableadvisors { get; set; } 

        [XmlElement(ElementName = "assignedadvisors")]
        public AdvisorsAssigned Assignedadvisors { get; set; } 

        [XmlElement(ElementName = "capitalresources")]
        public CharacterCapitalResources Capitalresources { get; set; }

        [XmlElement(ElementName = "unitstates")]
        public CharacterUnitstates Unitstates { get; set; } 

        [XmlElement(ElementName = "characterconfigs")]
        public CharacterConfigs Configs { get; set; }

        [XmlElement(ElementName = "craftschools")]
        public ModelCharacterCraftschools Craftschools { get; set; }

        [XmlElement(ElementName = "learneddesigns")]
        public ModelCharacterLearneddesigns Designslearned { get; set; }

        [XmlElement(ElementName = "vanitys")]
        public ModelCharacterVanities Vanities { get; set; }

        [XmlElement(ElementName = "unlockedregions")]
        public ModelCharacterUnlockedRegions Regionsunlocked { get; set; }        

    }

}
