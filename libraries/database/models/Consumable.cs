using System.ComponentModel;
using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.enums;


namespace Libraries.database.models
{
    /// <summary>
    /// Consumable model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "consumable")]
    public class ModelConsumable
    {

        public ModelConsumable()
        {

            Usable = new List<string>();
            Alliance = new List<string>();

        }

        [XmlElement(ElementName = "icon")]
        [DefaultValue(null)]
        public string Icon { get; set; }

        [XmlElement(ElementName = "rollovertextid")]
        public int Rollovertextid { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public int Displaynameid { get; set; }

        [XmlElement(ElementName = "stackable")]
        public string Stackable { get; set; }

        [XmlElement(ElementName = "stacksize")]
        public int Stacksize { get; set; }

        [XmlElement(ElementName = "offertype")]
        public OfferTypes Offertype { get; set; }

        [XmlElement(ElementName = "itemlevel")]
        public int Itemlevel { get; set; }

        [XmlElement(ElementName = "sellable")]
        public string Sellable { get; set; }

        [XmlElement(ElementName = "tradeable")]
        public string Tradeable { get; set; }

        [XmlElement(ElementName = "destroyable")]
        public string Destroyable { get; set; }

        [XmlElement(ElementName = "sellcostoverride")]
        public ModelGenericSellcostoverride Sellcostoverride { get; set; }

        [XmlElement(ElementName = "rarity")]
        public RarityTypesPrefix Rarity { get; set; }

        [XmlElement(ElementName = "power")]
        [DefaultValue(null)]
        public string Power { get; set; }

        [XmlElement(ElementName = "civmatchingtype")]
        public CivilizationsPrefix Civmatchingtype { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "charactermodifier")]
        [DefaultValue(null)]
        public string Charactermodifier { get; set; }

        [XmlElement(ElementName = "usable")]
        [DefaultValue(null)]
        public List<string> Usable { get; set; }

        [XmlAttribute(AttributeName = "type")]
        [DefaultValue(null)]
        public string Type { get; set; }

        [XmlElement(ElementName = "alliance")]
        [DefaultValue(null)]
        public List<string> Alliance { get; set; }

    }

}
