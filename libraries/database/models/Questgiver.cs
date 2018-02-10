using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.database.models.questgiver;


namespace Libraries.database.models
{

    /// <summary>
    /// Questgiver model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questgiver")]
    public class ModelQuestgiver : ModelBase
    {

        [XmlElement(ElementName = "name")]
        [DefaultValue(null)]
        public string Name { get; set; }

        [XmlElement(ElementName = "placeunittype")]
        [DefaultValue(null)]
        public string Placeunittype { get; set; }

        [XmlElement(ElementName = "status")]
        [DefaultValue(null)]
        public string Status { get; set; }

        [XmlElement(ElementName = "maptype")]
        [DefaultValue(null)]
        public string Maptype { get; set; }

        [XmlElement(ElementName = "overrides")]
        public ModelQuestgiverOverrides Overrides { get; set; }

        [XmlElement(ElementName = "location")]
        public ModelQuestgiverLocation Location { get; set; }

        [XmlElement(ElementName = "spawntrigger")]
        public ModelQuestgiverSpawntrigger Spawntrigger { get; set; }

        [XmlElement(ElementName = "despawntrigger")]
        public ModelQuestgiverDespawntrigger Despawntrigger { get; set; }

        [XmlElement(ElementName = "greetingstringid")]
        public int Greetingstringid { get; set; }

        [XmlElement(ElementName = "greetingsoundset")]
        [DefaultValue(null)]
        public string Greetingsoundset { get; set; }

        [XmlElement(ElementName = "farewellsoundset")]
        [DefaultValue(null)]
        public string Farewellsoundset { get; set; }

        [XmlElement(ElementName = "artset")]
        [DefaultValue(null)]
        public string Artset { get; set; }

        [XmlAttribute(AttributeName = "region")]
        public int Region { get; set; }

        [XmlAttribute(AttributeName = "altregion")]
        public int Altregion { get; set; }
        
    }

}
