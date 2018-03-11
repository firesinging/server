using System.Xml.Serialization;


namespace Libraries.database.models.questlistdata
{

    /// <summary>
    /// Quest list data net data model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "QuestNetData")]
    public class ModelQuestListNetData
    {

        public ModelQuestListNetData()
        {

            Characterids = new ModelQuestListNetDataCharacterIds();

        }

        [XmlElement(ElementName = "Filename")]
        public string Filename { get; set; }

        [XmlElement(ElementName = "PrereqsInvalidated")]
        public int PrereqsInvalidated { get; set; }

        [XmlElement(ElementName = "CharacterIds")]
        public ModelQuestListNetDataCharacterIds Characterids { get; set; }

        [XmlElement(ElementName = "prereqs")]
        public int Prereqs { get; set; }

    }

}

