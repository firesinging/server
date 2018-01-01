using System.Xml.Serialization;


namespace Libraries.database.models.quest.prereqs
{

    /// <summary>
    /// Or model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "or")]
    public class ModelQuestPrereqsOr
    {

        [XmlElement(ElementName = "values")]
        public ModelQuestPrereqsValues Values { get; set; }

    }

}
