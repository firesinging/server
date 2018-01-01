using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Vault inventory items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "EmpireVaultInventory")]
    public class ModelEmpireVaultInventoryItems
    {

        [XmlElement(ElementName = "InventoryItem")]
        public List<ModelEmpireVaultInventoryItem> InventoryItem { get; set; }

    }

}
