using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models.design;


namespace Libraries.database.models
{
    /// <summary>
    /// Design model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "econdesign")]
    public class ModelDesign
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

        [XmlElement(ElementName = "rarity")]
        public RarityTypesPrefix Rarity { get; set; }
        
        [XmlElement(ElementName = "productionpoints")]
        public int Productionpoints { get; set; }

        [XmlElement(ElementName = "output")]
        public ModelDesignOutput Output { get; set; }

        [XmlElement(ElementName = "outputtraitlevel")]
        public int Outputtraitlevel { get; set; }

        [XmlElement(ElementName = "autolearn")]
        public string Autolearn { get; set; }

        [XmlElement(ElementName = "autorepeat")]
        public string Autorepeat { get; set; }

        [XmlElement(ElementName = "tohopper")]
        public string Tohopper { get; set; }

        [XmlElement(ElementName = "ignoreschool")]
        public string Ignoreschool { get; set; }

        [XmlElement(ElementName = "advanced")]
        public string Advanced { get; set; }

        [XmlElement(ElementName = "tag")]
        [DefaultValue(null)]
        public string Tag { get; set; }
        
        [XmlElement(ElementName = "budgetmodifier")]
        [DefaultValue(null)]
        public string Budgetmodifier { get; set; }
        
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "sellcostoverride")]
        public ModelGenericSellcostoverride Sellcostoverride { get; set; }

        [XmlElement(ElementName = "input")]
        public ModelDesignInput Input { get; set; }

    }

}
