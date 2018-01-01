using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Vault inventory model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "EmpireVaultInventory")]
    public class ModelEmpireVaultInventory
    {

        [XmlElement(ElementName = "container")]
        public string Container { get; set; }

        [XmlElement(ElementName = "items")]
        public ModelEmpireVaultInventoryItems Items { get; set; }

    }

}
