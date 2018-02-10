using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character learned designs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "learneddesigns")]
    public class ModelCharacterLearneddesigns : ModelBase
    {

        public ModelCharacterLearneddesigns()
        {

            Items = new List<string>();

        }

        [XmlElement(ElementName = "learneddesign")]
        [DefaultValue(null)]
        public List<string> Items { get; set; }

    }

}
