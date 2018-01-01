using System.Xml.Serialization;
using System.Collections.Generic;

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

        [XmlElement(ElementName = "grouping")]
        public List<ModelTargetsGrouping> Grouping { get; set; }

        [XmlElement(ElementName = "protounit")]
        public List<ModelTargetsProtounit> Protounit { get; set; }

    }

}
