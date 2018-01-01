using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models
{

    /// <summary>
    /// Quest instances model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questinstances")]
    public class ModelQuestinstances
    {

        [XmlElement(ElementName = "questinstance")]
        public List<ModelQuestinstance> Questinstance { get; set; }

    }

}
