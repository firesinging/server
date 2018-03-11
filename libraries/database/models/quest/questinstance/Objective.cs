using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models.quest.instance
{

    /// <summary>
    /// Quest instance objective model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "objective")]
    [DefaultValue(null)]
    public class ModelQuestinstanceObjective
    {

        public ModelQuestinstanceObjective()
        {

            Objective = new List<ModelQuestinstanceObjective>();

        }

        [XmlElement(ElementName = "rewardname")]
        [DefaultValue(null)]
        public string RewardName { get; set; }

        [XmlElement(ElementName = "amount")]
        [DefaultValue(null)]
        public string Amount { get; set; }

        [XmlElement(ElementName = "count")]
        [DefaultValue(null)]
        public string Count { get; set; }

        [XmlElement(ElementName = "counted")]
        [DefaultValue(null)]
        public string Counted { get; set; }

        [XmlElement(ElementName = "status")]
        [DefaultValue(null)]
        public string Status { get; set; }

        [XmlAttribute(AttributeName = "type")]
        [DefaultValue(null)]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "mustfailall")]
        [DefaultValue(null)]
        public string MustFailAll { get; set; }

        [XmlElement(ElementName = "objective")]
        [DefaultValue(null)]
        public List<ModelQuestinstanceObjective> Objective { get; set; }

    }

}
