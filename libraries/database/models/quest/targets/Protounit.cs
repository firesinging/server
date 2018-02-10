using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.quest.targets
{

    /// <summary>
    /// Protounit model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "protounit")]
    public class ModelTargetsProtounit
    {

        [XmlElement(ElementName = "cooponly")]
        public string Cooponly { get; set; }

        [XmlElement(ElementName = "forcetocenter")]
        public string Forcetocenter { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "protoname")]
        [DefaultValue(null)]
        public string Protoname { get; set; }

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlElement(ElementName = "team")]
        public int Team { get; set; }

        [XmlElement(ElementName = "area")]
        [DefaultValue(null)]
        public string Area { get; set; }

        [XmlElement(ElementName = "overrides")]
        public ModelQuestTargetsOverrides Overrides { get; set; }

        [XmlElement(ElementName = "usequesttargetindicator")]
        public string Usequesttargetindicator { get; set; }

    }

}
