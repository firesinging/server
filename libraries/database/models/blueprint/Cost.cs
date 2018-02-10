using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.blueprint
{

    /// <summary>
    /// Blueprint cost model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "cost")]
    public class ModelBlueprintCost
    {

        public ModelBlueprintCost()
        {

            Items = new List<ModelGenericMaterial>();

        }

        [XmlElement(ElementName = "material")]
        [DefaultValue(null)]
        public List<ModelGenericMaterial> Items { get; set; }

    }

}
