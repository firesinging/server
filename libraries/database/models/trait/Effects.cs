using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.traits
{

    /// <summary>
    /// Effects model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "effects")]
    public class ModelTraitEffects
    {

        [XmlElement(ElementName = "effect")]
        public List<ModelTraitEffect> Effect { get; set; }

    }

}
