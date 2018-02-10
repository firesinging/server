using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Vault inventory model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "EmpireVaultInventory")]
    public class ModelPlayerVaultInventory : ModelBase
    {

        public ModelPlayerVaultInventory()
        {

            Items = new ModelPlayerVaultInventoryItems();

        }

        [XmlElement(ElementName = "container")]
        public string Container { get; set; }

        [XmlElement(ElementName = "items")]
        public ModelPlayerVaultInventoryItems Items { get; set; }

    }

}
