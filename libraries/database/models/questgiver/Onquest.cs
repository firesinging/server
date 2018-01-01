using System.Xml.Serialization;


namespace Libraries.database.models.questgiver
{

    /// <summary>
    /// Onquest model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "onquest")]
    public class ModelQuestgiverOnquest
    {

        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

    }

}
