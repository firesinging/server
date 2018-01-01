using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character inventory containers model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "inventorycontainers")]
    public class ModelCharacterInventoryContainers
    {

        [XmlElement(ElementName = "inventorycontainer")]
        public List<ModelCharacterInventorycontainer> Inventorycontainer { get; set; }

    }

}
