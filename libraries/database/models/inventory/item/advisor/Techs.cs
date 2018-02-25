using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.inventory.item.advisor
{

    /// <summary>
    /// Inventory item advisor tech model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "techs")]
    public class ModelInventoryItemAdvisorTechs
    {

        [XmlElement(ElementName = "tech")]
        [DefaultValue(null)]
        public string Tech { get; set; }

    }

}
