using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

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

        public ModelQuestRewards()
        {

            Gamecurrency = new List<ModelQuestRewardsGamecurrency>();
            Loottable = new List<ModelQuestRewardsLoottable>();
            Capitalresource = new List<ModelQuestRewardsCapitalresource>();
            Material = new List<ModelQuestRewardsMaterial>();
            Consumematerial = new List<ModelQuestRewardsConsumematerial>();
            Blueprint = new List<ModelQuestRewardsBlueprint>();
            Trait = new List<ModelQuestRewardsTrait>();
            Advisor = new List<ModelQuestRewardsAdvisor>();
            Capitaltech = new List<ModelQuestRewardsCapitaltech>();
            QuestGiver = new List<ModelQuestRewardsQuestGiver>();
            Unlockregion = new List<ModelQuestRewardsUnlockregion>();
            Lockregion = new List<ModelQuestRewardsLockregion>();
            Mailreward = new List<ModelQuestRewardsMailreward>();
            Or = new List<ModelQuestRewardsOr>();

        }

        [XmlElement(ElementName = "xp")]
        public ModelQuestRewardsXp Xp { get; set; }

        [XmlElement(ElementName = "alliancepoints")]
        public ModelQuestRewardsAlliancepoints Alliancepoints { get; set; }

        [XmlElement(ElementName = "gamecurrency")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsGamecurrency> Gamecurrency { get; set; }

        [XmlElement(ElementName = "loottable")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsLoottable> Loottable { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlElement(ElementName = "capitalresource")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsCapitalresource> Capitalresource { get; set; }

        [XmlElement(ElementName = "material")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsMaterial> Material { get; set; }

        [XmlElement(ElementName = "consumematerial")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsConsumematerial> Consumematerial { get; set; }

        [XmlElement(ElementName = "blueprint")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsBlueprint> Blueprint { get; set; }

        [XmlElement(ElementName = "consumable")]
        public ModelQuestRewardsConsumable Consumable { get; set; }

        [XmlElement(ElementName = "trait")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsTrait> Trait { get; set; }

        [XmlElement(ElementName = "advisor")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsAdvisor> Advisor { get; set; }

        [XmlElement(ElementName = "protip")]
        public ModelQuestRewardsProtip Protip { get; set; }

        [XmlElement(ElementName = "capitaltech")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsCapitaltech> Capitaltech { get; set; }

        [XmlElement(ElementName = "questgiver")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsQuestGiver> QuestGiver { get; set; }

        [XmlElement(ElementName = "unlockregion")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsUnlockregion> Unlockregion { get; set; }

        [XmlElement(ElementName = "lockregion")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsLockregion> Lockregion { get; set; }

        [XmlElement(ElementName = "mailreward")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsMailreward> Mailreward { get; set; }

        [XmlElement(ElementName = "enableprotip")]
        public ModelQuestRewardsEnableprotip Enableprotip { get; set; }

        [XmlElement(ElementName = "or")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsOr> Or { get; set; }

    }

}
