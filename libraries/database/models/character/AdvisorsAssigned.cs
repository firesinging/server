using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character assigned advisors model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "assignedadvisors")]
    public class ModelCharacterAdvisorsAssigned
    {

        [XmlElement(ElementName = "Age1")]
        public string Age1 { get; set; }

        [XmlElement(ElementName = "Age2")]
        public string Age2 { get; set; }

        [XmlElement(ElementName = "Age3")]
        public string Age3 { get; set; }

        [XmlElement(ElementName = "Age4")]
        public string Age4 { get; set; }

    }

}
