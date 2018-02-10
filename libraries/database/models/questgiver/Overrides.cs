using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.questgiver
{

    /// <summary>
    /// Onquest model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "overrides")]
    public class ModelQuestgiverOverrides
    {

        public ModelQuestgiverOverrides()
        {

            Items = new List<ModelQuestgiverOverride>();

        }

        [XmlElement(ElementName = "override")]
        [DefaultValue(null)]
        public List<ModelQuestgiverOverride> Items { get; set; }

    }

}
