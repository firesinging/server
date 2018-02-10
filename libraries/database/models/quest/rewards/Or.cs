using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Or model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "or")]
    public class ModelQuestRewardsOr
    {

        public ModelQuestRewardsOr()
        {

            Advisor = new List<ModelQuestRewardsAdvisor>();
            Material = new List<ModelQuestRewardsMaterial>();
            Consumable = new List<ModelQuestRewardsConsumable>();
            Blueprint = new List<ModelQuestRewardsBlueprint>();
            Trait = new List<ModelQuestRewardsTrait>();
            Loottable = new List<ModelQuestRewardsLoottable>();

        }
        
        [XmlElement(ElementName = "advisor")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsAdvisor> Advisor { get; set; }

        [XmlElement(ElementName = "material")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsMaterial> Material { get; set; }

        [XmlElement(ElementName = "consumable")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsConsumable> Consumable { get; set; }

        [XmlElement(ElementName = "blueprint")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsBlueprint> Blueprint { get; set; }

        [XmlElement(ElementName = "trait")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsTrait> Trait { get; set; }

        [XmlElement(ElementName = "loottable")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsLoottable> Loottable { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

    }

}
