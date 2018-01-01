using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.questinstance
{

    /// <summary>
    /// Quest instance objective model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "objective")]
    public class ModelQuestinstanceObjective
    {

        [XmlElement(ElementName = "rewardname")]
        public string RewardName { get; set; }

        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }

        [XmlElement(ElementName = "count")]
        public string Count { get; set; }

        [XmlElement(ElementName = "counted")]
        public string Counted { get; set; }

        [XmlElement(ElementName = "status")]
        public string Status { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "mustfailall")]
        public string MustFailAll { get; set; }

        [XmlElement(ElementName = "objective")]
        public List<ModelQuestinstanceObjective> Objective { get; set; }

    }

}
