using System.Xml.Serialization;


namespace Libraries.database.models.traits
{

    /// <summary>
    /// Effect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "effect")]
    public class ModelTraitEffect
    {

        [XmlElement(ElementName = "target")]
        public ModelTraitTarget Target { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "bonus")]
        public string Bonus { get; set; }

        [XmlAttribute(AttributeName = "amount")]
        public string Amount { get; set; }

        [XmlAttribute(AttributeName = "scaling")]
        public string Scaling { get; set; }

        [XmlAttribute(AttributeName = "subtype")]
        public string Subtype { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlAttribute(AttributeName = "damagetype")]
        public string Damagetype { get; set; }

        [XmlAttribute(AttributeName = "relativity")]
        public string Relativity { get; set; }

        [XmlAttribute(AttributeName = "allactions")]
        public string Allactions { get; set; }

        [XmlAttribute(AttributeName = "seedoffset")]
        public string Seedoffset { get; set; }

        [XmlAttribute(AttributeName = "resource")]
        public string Resource { get; set; }

        [XmlAttribute(AttributeName = "action")]
        public string Action { get; set; }

        [XmlAttribute(AttributeName = "unittype")]
        public string Unittype { get; set; }

    }

}
