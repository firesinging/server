using System.Xml.Serialization;


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

        [XmlElement(ElementName = "budgetcost")]
        public string Budgetcost { get; set; }

        [XmlElement(ElementName = "contentpack")]
        public string Contentpack { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

    }

}
