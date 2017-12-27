using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models
{
    /// <summary>
    /// Consumable model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "consumable")]
    public class ModelConsumable
    {

        [XmlElement(ElementName = "icon")]
        public string Icon { get; set; }

        [XmlElement(ElementName = "rollovertextid")]
        public string Rollovertextid { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public string Displaynameid { get; set; }

        [XmlElement(ElementName = "stackable")]
        public string Stackable { get; set; }

        [XmlElement(ElementName = "stacksize")]
        public string Stacksize { get; set; }

        [XmlElement(ElementName = "offertype")]
        public string Offertype { get; set; }

        [XmlElement(ElementName = "itemlevel")]
        public string Itemlevel { get; set; }

        [XmlElement(ElementName = "sellable")]
        public string Sellable { get; set; }

        [XmlElement(ElementName = "tradeable")]
        public string Tradeable { get; set; }

        [XmlElement(ElementName = "destroyable")]
        public string Destroyable { get; set; }

        [XmlElement(ElementName = "sellcostoverride")]
        public ModelGenericSellcostoverride Sellcostoverride { get; set; }

        [XmlElement(ElementName = "rarity")]
        public string Rarity { get; set; }

        [XmlElement(ElementName = "power")]
        public string Power { get; set; }

        [XmlElement(ElementName = "civmatchingtype")]
        public string Civmatchingtype { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "charactermodifier")]
        public string Charactermodifier { get; set; }

        [XmlElement(ElementName = "usable")]
        public List<string> Usable { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "alliance")]
        public List<string> Alliance { get; set; }

    }

}
