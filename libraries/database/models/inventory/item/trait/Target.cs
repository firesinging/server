using System.Xml.Serialization;


namespace Libraries.database.models.inventory.item.traits
{

    /// <summary>
    /// Inventory item target model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "target")]
    public class ModelInventoryItemTraitEffectsEffectTarget
    {

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

    }

}
