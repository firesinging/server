using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.database.models.quest.rewards;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Rewards model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "rewards")]
    public class ModelQuestRewards
    {

        [XmlElement(ElementName = "xp")]
        public ModelQuestRewardsXp Xp { get; set; }

        [XmlElement(ElementName = "alliancepoints")]
        public ModelQuestRewardsAlliancepoints Alliancepoints { get; set; }

        [XmlElement(ElementName = "gamecurrency")]
        public List<ModelQuestRewardsGamecurrency> Gamecurrency { get; set; }

        [XmlElement(ElementName = "loottable")]
        public List<ModelQuestRewardsLoottable> Loottable { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlElement(ElementName = "capitalresource")]
        public List<ModelQuestRewardsCapitalresource> Capitalresource { get; set; }

        [XmlElement(ElementName = "material")]
        public List<ModelQuestRewardsMaterial> Material { get; set; }

        [XmlElement(ElementName = "consumematerial")]
        public List<ModelQuestRewardsConsumematerial> Consumematerial { get; set; }

        [XmlElement(ElementName = "blueprint")]
        public List<ModelQuestRewardsBlueprint> Blueprint { get; set; }

        [XmlElement(ElementName = "consumable")]
        public ModelQuestRewardsConsumable Consumable { get; set; }

        [XmlElement(ElementName = "trait")]
        public List<ModelQuestRewardsTrait> Trait { get; set; }

        [XmlElement(ElementName = "advisor")]
        public List<ModelQuestRewardsAdvisor> Advisor { get; set; }

        [XmlElement(ElementName = "protip")]
        public ModelQuestRewardsProtip Protip { get; set; }

        [XmlElement(ElementName = "capitaltech")]
        public List<ModelQuestRewardsCapitaltech> Capitaltech { get; set; }

        [XmlElement(ElementName = "questgiver")]
        public List<ModelQuestRewardsQuestGiver> QuestGiver { get; set; }

        [XmlElement(ElementName = "unlockregion")]
        public List<ModelQuestRewardsUnlockregion> Unlockregion { get; set; }

        [XmlElement(ElementName = "lockregion")]
        public List<ModelQuestRewardsLockregion> Lockregion { get; set; }

        [XmlElement(ElementName = "mailreward")]
        public List<ModelQuestRewardsMailreward> Mailreward { get; set; }

        [XmlElement(ElementName = "enableprotip")]
        public ModelQuestRewardsEnableprotip Enableprotip { get; set; }

        [XmlElement(ElementName = "or")]
        public List<ModelQuestRewardsOr> Or { get; set; }

    }

}
