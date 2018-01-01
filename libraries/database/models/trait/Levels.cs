using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.traits
{

    /// <summary>
    /// Levels model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "levels")]
    public class ModelTraitLevels
    {

        [XmlElement(ElementName = "level")]
        public List<int> Level { get; set; }
    
    }

}
