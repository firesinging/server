using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Vault inventory item cost model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Cost")]
    public class ModelEmpireVaultInventoryItemCost
    {

        [XmlElement(ElementName = "CapitalResource")]
        public ModelGenericCapitalresource CapitalResource { get; set; }

    }

}
