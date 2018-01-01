using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character questgiver model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "trait")]
    public class ModelCharacterQuestgiver
    {

        [XmlElement(ElementName="name")]
		public string Name { get; set; }

		[XmlElement(ElementName="status")]
		public string Status { get; set; }     

    }

}
