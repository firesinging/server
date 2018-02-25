using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.inventory
{

    /// <summary>
    /// Inventory inventory model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "cost")]
    public class ModelInventoryInventoryItemCost
    {

        [XmlElement(ElementName = "capitalresource")]
        [DefaultValue(null)]
        public ModelGenericCapitalresource Capitalresource { get; set; }
        
        [XmlElement(ElementName = "gamecurrency")]
        [DefaultValue(null)]
        public ModelGenericGamecurrency Gamecurrency { get; set; }
        
    }

}
