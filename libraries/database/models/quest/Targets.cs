using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

using Libraries.database.models.quest.targets;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Targets model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "targets")]
    public class ModelQuestTargets
    {

        public ModelQuestTargets()
        {

            Grouping = new List<ModelTargetsGrouping>();
            Protounit = new List<ModelTargetsProtounit>();

        }

        [XmlElement(ElementName = "grouping")]
        [DefaultValue(null)]
        public List<ModelTargetsGrouping> Grouping { get; set; }

        [XmlElement(ElementName = "protounit")]
        [DefaultValue(null)]
        public List<ModelTargetsProtounit> Protounit { get; set; }

    }

}
