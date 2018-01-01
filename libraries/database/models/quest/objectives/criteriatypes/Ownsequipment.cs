using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Owns equipment model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ownsequipment")]
    public class ModelQuestObjectivesOwnsequipment
    {

        [XmlElement(ElementName="equipmentid")]
		public int Equipmentid { get; set; }

		[XmlAttribute(AttributeName="id")]
		public int Id { get; set; }

    }

}
