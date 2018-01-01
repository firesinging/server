using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.database.models.questinstance;


namespace Libraries.database.models
{

    /// <summary>
    /// Quest instance model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questinstance")]
    public class ModelQuestinstance
    {

        [XmlElement(ElementName = "objective")]
        public ModelQuestinstanceObjective Objective { get; set; }

        [XmlElement(ElementName = "secondaryobjective")]
        public List<ModelQuestinstanceObjective> Secondaryobjectives { get; set; }

        [XmlElement(ElementName = "giveregion")]
        public int Giveregion { get; set; }

        [XmlElement(ElementName = "returnregion")]
        public int Returnregion { get; set; }

        [XmlElement(ElementName = "Scale")]
        public int Scale { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }

        [XmlAttribute(AttributeName = "active")]
        public string Active { get; set; }

        [XmlElement(ElementName = "timer")]
        public ModelQuestTimer Timer { get; set; }

    }

}
