using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.quest.randommap
{

    /// <summary>
    /// Map variables model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "mapvariables")]
    public class ModelQuestRandommapMapvariables
    {

        public ModelQuestRandommapMapvariables()
        {

            Items = new List<ModelQuestRandommapMapvariable>();

        }

        [XmlElement(ElementName = "variable")]
        [DefaultValue(null)]
        public List<ModelQuestRandommapMapvariable> Items { get; set; }

    }

}
