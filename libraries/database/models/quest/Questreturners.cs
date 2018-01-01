using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Questreturners model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questreturners")]
    public class ModelQuestQuestreturners
    {

        [XmlElement(ElementName = "protounit")]
        public List<string> Protounit { get; set; }

    }

}
