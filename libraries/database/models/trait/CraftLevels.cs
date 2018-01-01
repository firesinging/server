using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.traits
{

    /// <summary>
    /// Craftlevels model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "craftlevels")]
    public class ModelTraitCraftLevels
    {

        [XmlElement(ElementName = "level")]
        public List<int> Level { get; set; }
    
    }

}
