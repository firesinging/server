using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models.traits;


namespace Libraries.database.models
{
    
    /// <summary>
    /// Trait model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "trait")]
    public class ModelTrait
    {

        [XmlElement(ElementName = "dbid")]
        public string Dbid { get; set; }

        [XmlElement(ElementName = "traittype")]
        public TraitTypes Traittype { get; set; }

        [XmlElement(ElementName = "rarity")]
        public RarityTypes Rarity { get; set; }

        [XmlElement(ElementName = "icon")]
        public string Icon { get; set; }

        [XmlElement(ElementName = "rollovertextid")]
        public string Rollovertextid { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public string Displaynameid { get; set; }

        [XmlElement(ElementName = "alliance")]
        public string Alliance { get; set; }

        [XmlElement(ElementName = "offertype")]
        public OfferTypes Offertype { get; set; }

        [XmlElement(ElementName = "equipsoundset")]
        public string Equipsoundset { get; set; }

        [XmlElement(ElementName = "visualfactor")]
        public ModelTraitVisualfactor Visualfactor { get; set; }

        [XmlElement(ElementName = "sellable")]
        public int Sellable { get; set; }

        [XmlElement(ElementName = "tradeable")]
        public int Tradeable { get; set; }

        [XmlElement(ElementName = "destroyable")]
        public int Destroyable { get; set; }

        [XmlElement(ElementName = "canbestoredingearhall")]
        public int Canbestoredingearhall { get; set; }

        [XmlElement(ElementName = "effects")]
        public ModelTraitEffects Effects { get; set; }

        [XmlElement(ElementName = "event")]
        public string Event { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "levels")]
        public ModelTraitLevels Levels { get; set; }

        [XmlElement(ElementName = "craftlevels")]
        public ModelTraitCraftLevels CraftLevels { get; set; }

        [XmlIgnore]
        public string Source { get; set; }

    }

}
