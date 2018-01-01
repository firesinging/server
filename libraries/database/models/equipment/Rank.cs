using System.Xml.Serialization;


namespace Libraries.database.models.equipment
{

    /// <summary>
    /// Equipment rank model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ranks")]
    public class ModelEquipmentRank
    {

        [XmlAttribute(AttributeName = "tech")]
        public string Tech { get; set; }

        [XmlAttribute(AttributeName = "cost")]
        public string Cost { get; set; }

        [XmlAttribute(AttributeName = "descid")]
        public string Descid { get; set; }

    }

}
