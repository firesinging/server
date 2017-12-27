using System.Xml.Serialization;


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

        [XmlElement(ElementName = "sellcostoverride")]
        public ModelGenericSellcostoverride Sellcostoverride { get; set; }

        [XmlElement(ElementName = "rarity")]
        public string Rarity { get; set; }

        [XmlElement(ElementName = "protounit")]
        public string Protounit { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "cost")]
        public ModelBlueprintCost Cost { get; set; }

        [XmlElement(ElementName = "tag")]
        public string Tag { get; set; }

        [XmlElement(ElementName = "alliance")]
        public string Alliance { get; set; }

        [XmlElement(ElementName = "event")]
        public string Event { get; set; }

    }

}
