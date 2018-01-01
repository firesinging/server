using System.Xml.Serialization;

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

        [XmlElement(ElementName = "aivariable")]
        public List<ModelQuestPlayersettingsAivariable> Aivariable { get; set; }

    }

}
