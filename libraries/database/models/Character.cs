using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models.character;


namespace Libraries.database.models
{
    
    /// <summary>
    /// Character model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "character")]
    public class ModelCharacter
    {

        public ModelCharacter()
        {

            Questinstances = new ModelQuestinstances();



        }

        [XmlAttribute(AttributeName = "id")]
        public long Id { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public int Version { get; set; } = 1;

        [XmlElement(ElementName = "CivId")]
        public Civilizations CivId { get; set; }

        [XmlElement(ElementName = "capscenario")]
        public string Capscenario { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "flag")]
        public long Flag { get; set; }

        [XmlElement(ElementName = "level")]
        public int Level { get; set; }

        [XmlElement(ElementName = "skillpoints")]
        public int Skillpoints { get; set; }

        [XmlElement(ElementName = "skillresetpoints")]
        public int Skillresetpoints { get; set; }

        [XmlElement(ElementName = "currentage")]
        public string Currentage { get; set; }

        [XmlElement(ElementName = "completedquests")]
        public string Completedquests { get; set; }

        [XmlElement(ElementName = "questinstances")]
        public ModelQuestinstances Questinstances { get; set; }

        [XmlElement(ElementName = "activetechs")]
        public ModelCharacterTechsActive Activetechs { get; set; }

        [XmlElement(ElementName = "capitaltechs")]
        public ModelCharacterTechsCapital Capitaltechs { get; set; }

        [XmlElement(ElementName = "protounits")]
        public ModelCharacterProtounits Protounits { get; set; } 

        [XmlElement(ElementName = "traits")]
        public ModelCharacterTraits Traits { get; set; }

        [XmlElement(ElementName = "inventorycontainers")]
        public ModelCharacterInventoryContainers Inventorycontainers { get; set; } 

        [XmlElement(ElementName = "capitallockedtiles")]
        public ModelCharacterCapitallockedtiles Capitallockedtiles { get; set; } 

        [XmlElement(ElementName = "questgivers")]
        public ModelCharacterQuestgivers Questgivers { get; set; } 

        [XmlElement(ElementName = "econdesigns")]
        public string Econdesigns { get; set; }

        [XmlElement(ElementName = "resources")]
        public ModelCharacterResources Resources { get; set; }

        [XmlElement(ElementName = "currentregion")]
        public int Currentregion { get; set; }

        [XmlElement(ElementName = "nextscenarioid")]
        public int Nextscenarioid { get; set; }

        [XmlElement(ElementName = "scenariodelta")]
        public byte[] Scenariodelta { get; set; }

        [XmlElement(ElementName = "availableadvisors")]
        public ModelCharacterAdvisorsAvailable Availableadvisors { get; set; } 

        [XmlElement(ElementName = "assignedadvisors")]
        public ModelCharacterAdvisorsAssigned Assignedadvisors { get; set; } 

        [XmlElement(ElementName = "capitalresources")]
        public ModelCharacterCapitalResources Capitalresources { get; set; }

        [XmlElement(ElementName = "clientstates")]
        public ModelCharacterClientStates Clientstates { get; set; } 

        [XmlElement(ElementName = "characterconfigs")]
        public ModelCharacterConfigs Configs { get; set; }

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
