using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.quest.randommap
{

    /// <summary>
    /// Map variables model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "mapvariables")]
    public class ModelQuestRandommapMapvariables
    {

        [XmlElement(ElementName = "variable")]
        public List<ModelQuestRandommapMapvariable> Variable { get; set; }

    }

}
