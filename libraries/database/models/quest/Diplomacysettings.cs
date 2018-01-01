using System.Xml.Serialization;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Diplomacysettings model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "diplomacy")]
    public class ModelQuestDiplomacysettings
    {

        [XmlAttribute(AttributeName = "relation")]
        public string Relation { get; set; }

        [XmlAttribute(AttributeName = "team1")]
        public string Team1 { get; set; }

        [XmlAttribute(AttributeName = "team2")]
        public string Team2 { get; set; }

        [XmlAttribute(AttributeName = "sharedlos")]
        public string Sharedlos { get; set; }

    }

}
