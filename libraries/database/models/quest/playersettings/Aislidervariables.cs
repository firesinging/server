using System.Xml.Serialization;

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

        [XmlElement(ElementName = "aivariable")]
        public List<ModelQuestPlayersettingsAivariable> Aivariable { get; set; }

    }

}
