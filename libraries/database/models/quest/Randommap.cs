using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.database.models.quest.randommap;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Randommap model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "randommap")]
    public class ModelQuestRandommap
    {

        [XmlElement(ElementName = "map")]
        [DefaultValue(null)]
        public string Map { get; set; }

        [XmlElement(ElementName = "randommap")]
        public string Randommap { get; set; }

        [XmlElement(ElementName = "numplayers")]
        public int Numplayers { get; set; }

        [XmlElement(ElementName = "mapvariables")]
        public ModelQuestRandommapMapvariables Mapvariables { get; set; }

        [XmlElement(ElementName = "nuggetoverrides")]
        public ModelQuestRandommapNuggetoverrides Nuggetoverrides { get; set; }

        [XmlElement(ElementName = "mapregionname")]
        [DefaultValue(null)]
        public string Mapregionname { get; set; }

        [XmlElement(ElementName = "lightsetname")]
        [DefaultValue(null)]
        public string Lightsetname { get; set; }

        [XmlElement(ElementName = "mapsizename")]
        [DefaultValue(null)]
        public string Mapsizename { get; set; }

    }

}
