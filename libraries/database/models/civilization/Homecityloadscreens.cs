using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization homecity loadscreens model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "homecityloadscreens")]
    public class ModelCivilizationHomecityloadscreens
    {

        [XmlElement(ElementName = "loadscreen")]
        [DefaultValue(null)]
        public string Loadscreen { get; set; }

    }

}
