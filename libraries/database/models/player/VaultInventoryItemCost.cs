using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Vault inventory item cost model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Cost")]
    public class ModelPlayerVaultInventoryItemCost
    {

        public ModelPlayerVaultInventoryItemCost()
        {

            CapitalResource = new ModelGenericCapitalresource();

        }

        [XmlElement(ElementName = "CapitalResource")]
        public ModelGenericCapitalresource CapitalResource { get; set; }

    }

}
