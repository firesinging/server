using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Questgivers model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questgivers")]
    public class ModelQuestQuestgivers
    {

        public ModelQuestQuestgivers()
        {

            Items = new List<string>();

        }

        [XmlElement(ElementName = "protounit")]
        [DefaultValue(null)]
        public List<string> Items { get; set; }

    }

}
