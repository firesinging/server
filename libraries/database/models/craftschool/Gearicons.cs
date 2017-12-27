using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models
{

    /// <summary>
    /// Gearicons model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gearicons")]
    public class ModelCraftschoolGearicons
    {

        [XmlElement(ElementName = "gear")]
        public List<ModelCraftschoolGear> Gear { get; set; }

    }

}
