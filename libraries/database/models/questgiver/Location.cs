using System.Xml.Serialization;


namespace Libraries.database.models.questgiver
{

    /// <summary>
    /// Location model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "location")]
    public class ModelQuestgiverLocation
    {

        [XmlElement(ElementName = "nearbuilding")]
        public ModelQuestgiverNearbuilding Nearbuilding { get; set; }

    }

}
