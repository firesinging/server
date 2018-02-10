using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Questreturners model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questreturners")]
    public class ModelQuestQuestreturners
    {

        public ModelQuestQuestreturners()
        {

            Items = new List<string>();

        }

        [XmlElement(ElementName = "protounit")]
        [DefaultValue(null)]
        public List<string> Items { get; set; }

    }

}
