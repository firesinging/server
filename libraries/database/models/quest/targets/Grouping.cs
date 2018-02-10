using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.quest.targets
{

    /// <summary>
    /// Grouping model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "grouping")]
    public class ModelTargetsGrouping
    {

        [XmlElement(ElementName = "cooponly")]
        public string Cooponly { get; set; }

        [XmlElement(ElementName = "forcetocenter")]
        public string Forcetocenter { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlElement(ElementName = "team")]
        public int Team { get; set; }

        [XmlElement(ElementName = "area")]
        [DefaultValue(null)]
        public string Area { get; set; }

        [XmlElement(ElementName = "groupfilename")]
        [DefaultValue(null)]
        public string Groupfilename { get; set; }

        [XmlElement(ElementName = "rottype")]
        [DefaultValue(null)]
        public string Rottype { get; set; }

        [XmlElement(ElementName = "rotateunitorientations")]
        [DefaultValue(null)]
        public string Rotateunitorientations { get; set; }

    }

}
