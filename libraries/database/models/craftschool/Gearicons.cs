using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.craftschool
{

    /// <summary>
    /// Craftschool gearicons model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gearicons")]
    public class ModelCraftschoolGearicons
    {

        public ModelCraftschoolGearicons()
        {

            Items = new List<ModelCraftschoolGear>();

        }

        [XmlElement(ElementName = "gear")]
        [DefaultValue(null)]
        public List<ModelCraftschoolGear> Items { get; set; }

    }

}
