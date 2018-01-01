using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character capital tech model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "item")]
    public class ModelCharacterTechCapital
    {

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlText]
        public int Active { get; set; }

    }

}
