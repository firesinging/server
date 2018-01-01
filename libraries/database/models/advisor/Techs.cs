using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.advisor
{

    /// <summary>
    /// Adivsor tech model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "techs")]
    public class ModelAdvisorTechs
    {

        [XmlElement(ElementName = "tech")]
        [DefaultValue(null)]
        public string Tech { get; set; }

    }

}
