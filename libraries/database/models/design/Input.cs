using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.design
{

    /// <summary>
    /// Design input model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "input")]
    public class ModelDesignInput
    {

        public ModelDesignInput()
        {

            Items = new List<ModelGenericMaterial>();

        }

        [XmlElement(ElementName = "material")]
        [DefaultValue(null)]
        public List<ModelGenericMaterial> Items { get; set; }

    }

}
