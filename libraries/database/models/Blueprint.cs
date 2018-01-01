using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models.blueprint;


namespace Libraries.database.models
{
    /// <summary>
    /// Blueprint model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "blueprint")]
    public class ModelBlueprint
    {

        [XmlElement(ElementName = "icon")]
        [DefaultValue(null)]
        public string Icon { get; set; }

        [XmlElement(ElementName = "rollovertextid")]
        public int Rollovertextid { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public int Displaynameid { get; set; }

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

        [XmlElement(ElementName = "protounit")]
        [DefaultValue(null)]
        public string Protounit { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "cost")]
        public ModelBlueprintCost Cost { get; set; }

        [XmlElement(ElementName = "tag")]
        [DefaultValue(null)]
        public string Tag { get; set; }

        [XmlElement(ElementName = "alliance")]
        [DefaultValue(null)]
        public string Alliance { get; set; }

        [XmlElement(ElementName = "event")]
        [DefaultValue(null)]
        public string Event { get; set; }

    }

}
