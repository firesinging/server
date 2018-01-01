using System.Xml.Serialization;


namespace Libraries.database.models.quest.targets
{

    /// <summary>
    /// Overrides model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "overrides")]
    public class ModelQuestTargetsOverrides
    {

        [XmlElement(ElementName = "displaynameid")]
        public string Displaynameid { get; set; }

        [XmlElement(ElementName = "visualscale")]
        public string Visualscale { get; set; }

        [XmlElement(ElementName = "initialhitpoints")]
        public string Initialhitpoints { get; set; }

        [XmlElement(ElementName = "maxhitpoints")]
        public string Maxhitpoints { get; set; }

        [XmlElement(ElementName = "convertresist")]
        public string Convertresist { get; set; }

        [XmlAttribute(AttributeName = "parent")]
        public string Parent { get; set; }

    }

}
