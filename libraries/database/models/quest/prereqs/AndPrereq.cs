using System.Xml.Serialization;


namespace Libraries.database.models.quest.prereqs
{

    /// <summary>
    /// And model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "and")]
    public class ModelQuestPrereqsAnd
    {

        [XmlElement(ElementName = "values")]
        public ModelQuestPrereqsValues Values { get; set; }

    }

}
