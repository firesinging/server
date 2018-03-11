using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.quest
{
    /// <summary>
    /// Quest nugget data model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Nuggets")]
    public class ModelQuestNuggetdata
    {

        public ModelQuestNuggetdata()
        {

            Items = new List<int>();

        }

        [XmlElement(ElementName = "QuestId")]
        public int QuestId { get; set; }

        [XmlElement(ElementName = "NInst")]
        [DefaultValue(null)]
        public List<int> Items { get; set; }

    }
}
