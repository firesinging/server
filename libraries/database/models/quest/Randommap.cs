using System.Xml.Serialization;

using Libraries.database.models.randommap;


namespace Libraries.database.models
{

    /// <summary>
    /// Randommap model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "randommap")]
    public class ModelQuestRandommap
    {

        [XmlElement(ElementName = "map")]
        public string Map { get; set; }

        [XmlElement(ElementName = "randommap")]
        public string Randommap { get; set; }

        [XmlElement(ElementName = "numplayers")]
        public string Numplayers { get; set; }

        [XmlElement(ElementName = "mapvariables")]
        public ModelQuestRandommapMapvariables Mapvariables { get; set; }

        [XmlElement(ElementName = "nuggetoverrides")]
        public ModelQuestRandommapNuggetoverrides Nuggetoverrides { get; set; }

        [XmlElement(ElementName = "mapregionname")]
        public string Mapregionname { get; set; }

        [XmlElement(ElementName = "lightsetname")]
        public string Lightsetname { get; set; }

        [XmlElement(ElementName = "mapsizename")]
        public string Mapsizename { get; set; }

    }

}
