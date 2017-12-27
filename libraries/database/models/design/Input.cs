using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models
{

    /// <summary>
    /// Input model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "input")]
    public class ModelDesignInput
    {

        [XmlElement(ElementName = "material")]
        public List<ModelGenericMaterial> Material { get; set; }

    }

}
