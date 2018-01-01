using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Vault model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "EmpireVault")]
    public class ModelEmpireVault
    {

        [XmlElement(ElementName = "EmpireVaultInventory")]
        public ModelEmpireVaultInventory EmpireVaultInventory { get; set; }

        [XmlAttribute(AttributeName = "EmpireVaultSize")]
        public int EmpireVaultSize { get; set; }

    }

}
