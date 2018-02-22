using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character client unitstate action production model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "production")]
    public class ModelCharacterUnitStateClientActionProduction
    {

        [XmlAttribute(AttributeName = "designid")]
        public int DesignId { get; set; }

        [XmlAttribute(AttributeName = "designname")]
        public string DesignName { get; set; }

    }

}
