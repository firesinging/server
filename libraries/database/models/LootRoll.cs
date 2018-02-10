using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;


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
        [DefaultValue(null)]
        public string Icon { get; set; }

        [XmlElement(ElementName = "rollovertextid")]
        public int Rollovertextid { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public int Displaynameid { get; set; }

        [XmlElement(ElementName = "itemlevel")]
        public int Itemlevel { get; set; }

        [XmlElement(ElementName = "rarity")]
        public RarityTypesPrefix Rarity { get; set; }

        [XmlElement(ElementName = "loottable")]
        [DefaultValue(null)]
        public string Loottable { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

    }

}
