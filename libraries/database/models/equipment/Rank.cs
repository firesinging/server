using System.ComponentModel;
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
        [DefaultValue(null)]
        public string Tech { get; set; }

        [XmlAttribute(AttributeName = "cost")]
        public int Cost { get; set; }

        [XmlAttribute(AttributeName = "descid")]
        public int Descid { get; set; }

    }

}
