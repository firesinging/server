using System.ComponentModel;
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
        [DefaultValue(null)]
        public string Age1 { get; set; }

        [XmlElement(ElementName = "Age2")]
        [DefaultValue(null)]
        public string Age2 { get; set; }

        [XmlElement(ElementName = "Age3")]
        [DefaultValue(null)]
        public string Age3 { get; set; }

        [XmlElement(ElementName = "Age4")]
        [DefaultValue(null)]
        public string Age4 { get; set; }

    }

}
