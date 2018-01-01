using System.Xml.Serialization;


namespace Libraries.database.models.quest.playersettings
{

    /// <summary>
    /// Aivariable model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "aivariable")]
    public class ModelQuestPlayersettingsAivariable
    {

        [XmlElement(ElementName = "key")]
        public string Key { get; set; }

        [XmlElement(ElementName = "value")]
        public string Value { get; set; }

    }

}
