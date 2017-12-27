using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Techs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "techs")]
    public class ModelAdvisorTechs
    {

        [XmlElement(ElementName = "tech")]
        public string Tech { get; set; }

    }

}
