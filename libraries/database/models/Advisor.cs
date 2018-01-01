using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models.advisor;


namespace Libraries.database.models
{
    
    /// <summary>
    /// Advisor model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "advisor")]
    public class ModelAdvisor
    {   
        
        [XmlElement(ElementName = "age")]
        public int Age { get; set; }

        [XmlElement(ElementName = "rarity")]
        public RarityTypes Rarity { get; set; }

        [XmlElement(ElementName = "icon")]
        [DefaultValue(null)]
        public string Icon { get; set; }
        
        [XmlElement(ElementName = "icontexturecoords")]
        [DefaultValue(null)]
        public string Icontexturecoords { get; set; }
        
        [XmlElement(ElementName = "rollovertextid")]
        [DefaultValue(null)]
        public string Rollovertextid { get; set; }
        
        [XmlElement(ElementName = "displaynameid")]
        public int Displaynameid { get; set; }

        [XmlElement(ElementName = "displaydescriptionid")]
        public int Displaydescriptionid { get; set; }
        
        [XmlElement(ElementName = "sellcostoverride")]
        public ModelGenericSellcostoverride Sellcostoverride { get; set; }

        [XmlElement(ElementName = "minlevel")]
        public int Minlevel { get; set; }

        [XmlElement(ElementName = "itemlevel")]
        public int Itemlevel { get; set; }

        [XmlElement(ElementName = "offertype")]
        public OfferTypes Offertype { get; set; }

        [XmlElement(ElementName = "techs")]
        public ModelAdvisorTechs Techs { get; set; }
        
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        
        [XmlAttribute(AttributeName = "groupid")]
        public int Groupid { get; set; }
        
        [XmlElement(ElementName = "sellable")]
        public string Sellable { get; set; }

        [XmlElement(ElementName = "tradeable")]
        public string Tradeable { get; set; }

        [XmlElement(ElementName = "destroyable")]
        public string Destroyable { get; set; }

        [XmlElement(ElementName = "specialborder")]
        [DefaultValue(null)]
        public string Specialborder { get; set; }

        [XmlElement(ElementName = "shortdescriptionid")]
        public int Shortdescriptionid { get; set; }

        [XmlElement(ElementName = "civilization")]
        [DefaultValue(null)]
        public string Civilization { get; set; }
        
    }

}
