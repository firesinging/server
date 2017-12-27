using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Homecity loadscreens model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "homecityloadscreens")]
    public class ModelCivilizationHomecityloadscreens
    {

        [XmlElement(ElementName = "loadscreen")]
        public string Loadscreen { get; set; }

    }

}
