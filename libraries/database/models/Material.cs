using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;


namespace Libraries.database.models
{
    /// <summary>
    /// Material model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "material")]
    public class ModelMaterial
    {

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

        [XmlElement(ElementName = "budgetcost")]
        public int Budgetcost { get; set; }

        [XmlElement(ElementName = "contentpack")]
        public int Contentpack { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

    }

}
