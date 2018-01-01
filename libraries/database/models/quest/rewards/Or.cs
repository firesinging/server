using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Or model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "or")]
    public class ModelQuestRewardsOr
    {

        [XmlElement(ElementName = "advisor")]
        public List<ModelQuestRewardsAdvisor> Advisor { get; set; }

        [XmlElement(ElementName = "material")]
        public List<ModelQuestRewardsMaterial> Material { get; set; }

        [XmlElement(ElementName = "consumable")]
        public List<ModelQuestRewardsConsumable> Consumable { get; set; }

        [XmlElement(ElementName = "blueprint")]
        public List<ModelQuestRewardsBlueprint> Blueprint { get; set; }

        [XmlElement(ElementName = "trait")]
        public List<ModelQuestRewardsTrait> Trait { get; set; }

        [XmlElement(ElementName = "loottable")]
        public List<ModelQuestRewardsLoottable> Loottable { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

    }

}
