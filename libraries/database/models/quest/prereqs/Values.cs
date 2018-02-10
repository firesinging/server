using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.quest.prereqs
{

    /// <summary>
    /// Values model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "values")]
    public class ModelQuestPrereqsValues
    {

        public ModelQuestPrereqsValues()
        {

            Questcomplete = new List<ModelQuestPrereqsQuestcomplete>();
            Civilization = new List<ModelQuestPrereqsCivilization>();
            Queststatus = new List<ModelQuestPrereqsQueststatus>();
            Or = new List<ModelQuestPrereqsOr>();
            And = new List<ModelQuestPrereqsAnd>();

        }

        [XmlElement(ElementName = "questcomplete")]
        [DefaultValue(null)]
        public List<ModelQuestPrereqsQuestcomplete> Questcomplete { get; set; }
        
        [XmlElement(ElementName = "level")]
        public ModelQuestPrereqsLevel Level { get; set; }

        [XmlElement(ElementName = "civilization")]
        [DefaultValue(null)]
        public List<ModelQuestPrereqsCivilization> Civilization { get; set; }       

        [XmlElement(ElementName = "queststatus")]
        [DefaultValue(null)]
        public List<ModelQuestPrereqsQueststatus> Queststatus { get; set; }

        [XmlElement(ElementName = "or")]
        [DefaultValue(null)]
        public List<ModelQuestPrereqsOr> Or { get; set; }

        [XmlElement(ElementName = "and")]
        [DefaultValue(null)]
        public List<ModelQuestPrereqsAnd> And { get; set; }

    }

}
