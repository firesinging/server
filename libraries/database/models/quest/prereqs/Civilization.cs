using System.Xml.Serialization;

using Libraries.enums;


namespace Libraries.database.models.quest.prereqs
{

    /// <summary>
    /// Civilization model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "civilizatio")]
    public class ModelQuestPrereqsCivilization
    {

        [XmlElement(ElementName = "id")]
        public Civilizations Id { get; set; }

    }

}
