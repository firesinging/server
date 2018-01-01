using System.Xml.Serialization;

using Libraries.database.models.quest.prereqs;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Prereqs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "prereqs")]
    public class ModelQuestPrereqs
    {

        [XmlElement(ElementName = "values")]
        public ModelQuestPrereqsValues Values { get; set; }

    }

}
