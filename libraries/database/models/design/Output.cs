using System.Xml.Serialization;


namespace Libraries.database.models.design
{

    /// <summary>
    /// Design output model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "output")]
    public class ModelDesignOutput
    {

        [XmlElement(ElementName = "material")]
        public ModelGenericMaterial Material { get; set; }

        [XmlElement(ElementName = "trait")]
        public ModelGenericTrait Trait { get; set; }

        [XmlElement(ElementName = "consumable")]
        public ModelDesignOutputConsumable Consumable { get; set; }

    }

}
