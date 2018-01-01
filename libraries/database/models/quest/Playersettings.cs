using System.Xml.Serialization;

using Libraries.database.models.quest.playersettings;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Playersettings model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "playersettings")]
    public class ModelQuestPlayersettings
    {

        [XmlElement(ElementName = "team")]
        public string Team { get; set; }

        [XmlElement(ElementName = "color")]
        public string Color { get; set; }

        [XmlElement(ElementName = "tributablebehavior")]
        public string Tributablebehavior { get; set; }

        [XmlElement(ElementName = "playertype")]
        public string Playertype { get; set; }

        [XmlElement(ElementName = "cooponly")]
        public string Cooponly { get; set; }

        [XmlElement(ElementName = "startingfood")]
        public int Startingfood { get; set; }

        [XmlElement(ElementName = "startingwood")]
        public int Startingwood { get; set; }

        [XmlElement(ElementName = "startinggold")]
        public int Startinggold { get; set; }

        [XmlElement(ElementName = "startingstone")]
        public int Startingstone { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "personality")]
        public string Personality { get; set; }

        [XmlElement(ElementName = "script")]
        public string Script { get; set; }

        [XmlElement(ElementName = "dataset")]
        public string Dataset { get; set; }

        [XmlElement(ElementName = "aislidervariables")]
        public ModelQuestPlayersettingsAislidervariables Aislidervariables { get; set; }

        [XmlElement(ElementName = "aiflagvariables")]
        public ModelQuestPlayersettingsAiflagvariables Aiflagvariables { get; set; }

    }

}
