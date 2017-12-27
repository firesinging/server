using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Questgiver model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questgiver")]
    public class ModelQuestgiver
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "placeunittype")]
        public string Placeunittype { get; set; }

        [XmlElement(ElementName = "status")]
        public string Status { get; set; }

        [XmlElement(ElementName = "maptype")]
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
        public string Greetingstringid { get; set; }

        [XmlElement(ElementName = "greetingsoundset")]
        public string Greetingsoundset { get; set; }

        [XmlElement(ElementName = "farewellsoundset")]
        public string Farewellsoundset { get; set; }

        [XmlElement(ElementName = "artset")]
        public string Artset { get; set; }

        [XmlAttribute(AttributeName = "region")]
        public string Region { get; set; }

        [XmlAttribute(AttributeName = "altregion")]
        public string Altregion { get; set; }
        
    }

}
