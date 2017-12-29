using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.traits
{

    /// <summary>
    /// Visualfactor model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "visualfactor")]
    public class ModelTraitVisualfactor
    {

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "factor")]
        public string Factor { get; set; }

    }

}
