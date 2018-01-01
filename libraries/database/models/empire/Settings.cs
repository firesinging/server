using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Settings model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Settings")]
    public class ModelEmpireSettings
    {

        [XmlElement(ElementName = "Setting")]
        public List<ModelEmpireSetting> Setting { get; set; }

        [XmlAttribute(AttributeName = "Version")]
        public int Version { get; set; }

    }

}
