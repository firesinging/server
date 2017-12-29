using System.Xml.Serialization;


namespace Libraries.database.models.traits
{

    /// <summary>
    /// Target model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "target")]
    public class ModelTraitTarget
    {

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

    }

}
