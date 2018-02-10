using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.traits
{

    /// <summary>
    /// Effects model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "effects")]
    public class ModelTraitEffects
    {

        public ModelTraitEffects()
        {

            Items = new List<ModelTraitEffect>();

        }

        [XmlElement(ElementName = "effect")]
        [DefaultValue(null)]
        public List<ModelTraitEffect> Items { get; set; }

    }

}
