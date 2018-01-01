using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Questgivers model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questgivers")]
    public class ModelQuestQuestgivers
    {

        [XmlElement(ElementName = "protounit")]
        public List<string> Protounit { get; set; }

    }

}
