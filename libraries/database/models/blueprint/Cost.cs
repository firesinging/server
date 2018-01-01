using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.blueprint
{

    /// <summary>
    /// Blueprint cost model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "cost")]
    public class ModelBlueprintCost
    {

        [XmlElement(ElementName = "material")]
        public List<ModelGenericMaterial> Material { get; set; }

    }

}
