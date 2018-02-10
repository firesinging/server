using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;


namespace Libraries.database.models.quest.playersettings
{

    /// <summary>
    /// Aislidervariables model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "aiflagvariables")]
    public class ModelQuestPlayersettingsAislidervariables
    {

        public ModelQuestPlayersettingsAislidervariables()
        {

            Items = new List<ModelQuestPlayersettingsAivariable>();

        }

        [XmlElement(ElementName = "aivariable")]
        [DefaultValue(null)]
        public List<ModelQuestPlayersettingsAivariable> Items { get; set; }

    }

}
