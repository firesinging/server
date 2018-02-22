using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.nugget
{

    /// <summary>
    /// Animnugget guardian unit model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "guardianunit")]
    public class ModelNuggetAnimnuggetGuardianunit
    {

        [XmlElement(ElementName = "unit")]
        [DefaultValue(null)]
        public string Unit { get; set; }

        [XmlElement(ElementName = "attachdummy")]
        [DefaultValue(null)]
        public string Attachdummy { get; set; }

    }

}
