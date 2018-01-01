using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.questgiver
{

    /// <summary>
    /// Onquest model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "overrides")]
    public class ModelQuestgiverOverrides
    {

        [XmlElement(ElementName = "override")]
        public List<ModelQuestgiverOverride> Override { get; set; }

    }

}
