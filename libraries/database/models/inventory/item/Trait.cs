using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models.inventory.item.traits;


namespace Libraries.database.models.inventory.item
{
    
    /// <summary>
    /// Trait model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>
    public class ModelInventoryItemTrait
    {

        public ModelInventoryItemTrait()
        {

            Visualfactor = new ModelInventoryItemTraitVisualfactor();
            Effects = new ModelInventoryItemTraitEffects();
            Levels = new ModelInventoryItemTraitLevels();
            CraftLevels = new ModelInventoryItemTraitCraftLevels();
            
        }

        [XmlElement(ElementName = "dbid")]
        public int Dbid { get; set; }

        [XmlElement(ElementName = "traittype")]
        public TraitTypes Traittype { get; set; }

        [XmlElement(ElementName = "rarity")]
        public RarityTypes Rarity { get; set; }

        [XmlElement(ElementName = "icon")]
        [DefaultValue(null)]
        public string Icon { get; set; }

        [XmlElement(ElementName = "rollovertextid")]
        public int Rollovertextid { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public int Displaynameid { get; set; }

        [XmlElement(ElementName = "alliance")]
        public string Alliance { get; set; }

        [XmlElement(ElementName = "offertype")]
        public OfferTypes Offertype { get; set; }

        [XmlElement(ElementName = "equipsoundset")]
        [DefaultValue(null)]
        public string Equipsoundset { get; set; }

        [XmlElement(ElementName = "visualfactor")]
        public ModelInventoryItemTraitVisualfactor Visualfactor { get; set; }

        [XmlElement(ElementName = "sellable")]
        public int Sellable { get; set; }

        [XmlElement(ElementName = "tradeable")]
        public int Tradeable { get; set; }

        [XmlElement(ElementName = "destroyable")]
        public int Destroyable { get; set; }

        [XmlElement(ElementName = "canbestoredingearhall")]
        public int Canbestoredingearhall { get; set; }

        [XmlElement(ElementName = "effects")]
        public ModelInventoryItemTraitEffects Effects { get; set; }

        [XmlElement(ElementName = "event")]
        [DefaultValue(null)]
        public string Event { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "levels")]
        public ModelInventoryItemTraitLevels Levels { get; set; }

        [XmlElement(ElementName = "craftlevels")]
        public ModelInventoryItemTraitCraftLevels CraftLevels { get; set; }

        [XmlIgnore]
        public string Source { get; set; }

    }

}
