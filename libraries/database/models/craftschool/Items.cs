using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.craftschool
{

    /// <summary>
    /// Craftschool items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "items")]
    public class ModelCraftschoolItems
    {

        [XmlElement(ElementName = "consumable")]
        public List<string> Consumable { get; set; }

        [XmlElement(ElementName = "advisor")]
        public List<string> Advisor { get; set; }

    }

}
