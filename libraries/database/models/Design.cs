using System.Xml.Serialization;


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
        public string Icon { get; set; }

        [XmlElement(ElementName = "rollovertextid")]
        public string Rollovertextid { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public string Displaynameid { get; set; }

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

        [XmlElement(ElementName = "rarity")]
        public string Rarity { get; set; }

        [XmlElement(ElementName = "productionpoints")]
        public string Productionpoints { get; set; }

        [XmlElement(ElementName = "output")]
        public ModelDesignOutput Output { get; set; }

        [XmlElement(ElementName = "outputtraitlevel")]
        public string Outputtraitlevel { get; set; }

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
        public string Tag { get; set; }

        [XmlElement(ElementName = "budgetmodifier")]
        public string Budgetmodifier { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "sellcostoverride")]
        public ModelGenericSellcostoverride Sellcostoverride { get; set; }

        [XmlElement(ElementName = "input")]
        public ModelDesignInput Input { get; set; }

    }

}
