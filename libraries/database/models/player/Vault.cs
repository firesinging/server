using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Vault model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "EmpireVault")]
    public class ModelPlayerVault : ModelBase
    {

        public ModelPlayerVault()
        {

            EmpireVaultInventory = new ModelPlayerVaultInventory();

        }

        [XmlElement(ElementName = "EmpireVaultInventory")]
        public ModelPlayerVaultInventory EmpireVaultInventory { get; set; }

        [XmlAttribute(AttributeName = "EmpireVaultSize")]
        public int EmpireVaultSize { get; set; }

    }

}
