using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character inventory containers inventory items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "items")]
    public class ModelCharacterInventorycontainerInventoryItems
    {

        [XmlElement(ElementName = "InventoryItem")]
        public List<ModelCharacterInventorycontainerInventoryItem> InventoryItem { get; set; }

    }

}
