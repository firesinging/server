using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.questlistdata
{

    /// <summary>
    /// Quest list data net data character id model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "CharacterIds")]
    public class ModelQuestListNetDataCharacterIds
    {

        public ModelQuestListNetDataCharacterIds()
        {

            Characterid = new List<long>();

        }

        [XmlElement(ElementName = "id")]
        [DefaultValue(null)]
        public List<long> Characterid { get; set; }

    }

}