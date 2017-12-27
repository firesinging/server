using System.Xml.Serialization;


namespace Libraries.database.models
{
    /// <summary>
    /// Loot roll model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "lootroll")]
    public class ModelLootRoll
    {

        [XmlElement(ElementName = "icon")]
        public string Icon { get; set; }

        [XmlElement(ElementName = "rollovertextid")]
        public string Rollovertextid { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public string Displaynameid { get; set; }

        [XmlElement(ElementName = "itemlevel")]
        public string Itemlevel { get; set; }

        [XmlElement(ElementName = "rarity")]
        public string Rarity { get; set; }

        [XmlElement(ElementName = "loottable")]
        public string Loottable { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

    }

}
