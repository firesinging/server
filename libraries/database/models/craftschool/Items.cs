using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.craftschool
{

    /// <summary>
    /// Craftschool items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "items")]
    public class ModelCraftschoolItems
    {

        public ModelCraftschoolItems()
        {

            Consumable = new List<string>();
            Advisor = new List<string>();

        }

        [XmlElement(ElementName = "consumable")]
        [DefaultValue(null)]
        public List<string> Consumable { get; set; }

        [XmlElement(ElementName = "advisor")]
        [DefaultValue(null)]
        public List<string> Advisor { get; set; }

    }

}
