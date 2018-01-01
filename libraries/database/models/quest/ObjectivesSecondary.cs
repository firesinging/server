using System.Xml.Serialization;

using Libraries.database.models.quest.objectives;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Secondary objectives model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "secondaryobjectives")]
    public class ModelQuestSecondaryobjectives
    {

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "values")]
        public ModelQuestObjectivesValues Values { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "mustfailall")]
        public string Mustfailall { get; set; }

        [XmlAttribute(AttributeName = "rewardname")]
        public string Rewardname { get; set; }

    }

}
