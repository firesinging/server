using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;


namespace Libraries.database.models.quest.playersettings
{

    /// <summary>
    /// Aiflagvariables model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "aiflagvariables")]
    public class ModelQuestPlayersettingsAiflagvariables
    {

        public ModelQuestPlayersettingsAiflagvariables()
        {

            Items = new List<ModelQuestPlayersettingsAivariable>();

        }

        [XmlElement(ElementName = "aivariable")]
        [DefaultValue(null)]
        public List<ModelQuestPlayersettingsAivariable> Items { get; set; }

    }

}
