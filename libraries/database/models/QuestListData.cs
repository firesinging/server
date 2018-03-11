using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.database.models.questlistdata;


namespace Libraries.database.models
{

    /// <summary>
    /// Quest list data model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "QuestListData")]
    public class ModelQuestListData : ModelBase
    {

        public ModelQuestListData()
        {

            QuestNetdata = new List<ModelQuestListNetData>();

        }

        [XmlElement(ElementName = "QuestNetData")]
        [DefaultValue(null)]
        public List<ModelQuestListNetData> QuestNetdata { get; set; }

    }

}