using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.craftschool
{

    /// <summary>
    /// Craftschool gearicons model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gearicons")]
    public class ModelCraftschoolGearicons
    {

        [XmlElement(ElementName = "gear")]
        public List<ModelCraftschoolGear> Gear { get; set; }

    }

}
