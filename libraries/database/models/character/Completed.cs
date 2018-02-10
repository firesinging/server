using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Completed model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "completedquests")]
    public class ModelQuestCompleted : ModelBase
    {

        public ModelQuestCompleted()
        {

            Items = new List<int>();

        }

        [XmlElement(ElementName = "questid")]
        [DefaultValue(null)]
        public List<int> Items { get; set; }

    }

}
