using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.quest.prereqs
{

    /// <summary>
    /// Values model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "values")]
    public class ModelQuestPrereqsValues
    {

        [XmlElement(ElementName = "questcomplete")]
        public List<ModelQuestPrereqsQuestcomplete> Questcomplete { get; set; }
        
        [XmlElement(ElementName = "level")]
        public ModelQuestPrereqsLevel Level { get; set; }

        [XmlElement(ElementName = "civilization")]
        public List<ModelQuestPrereqsCivilization> Civilization { get; set; }       

        [XmlElement(ElementName = "queststatus")]
        public List<ModelQuestPrereqsQueststatus> Queststatus { get; set; }

        [XmlElement(ElementName = "or")]
        public List<ModelQuestPrereqsOr> Or { get; set; }

        [XmlElement(ElementName = "and")]
        public List<ModelQuestPrereqsAnd> And { get; set; }

    }

}
