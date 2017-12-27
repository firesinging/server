using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models
{

    /// <summary>
    /// Cost model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "cost")]
    public class ModelBlueprintCost
    {

        [XmlElement(ElementName = "material")]
        public List<ModelGenericMaterial> Material { get; set; }

    }

}
