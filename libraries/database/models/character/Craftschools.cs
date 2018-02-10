using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character craftschools model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "craftschools")]
    public class ModelCharacterCraftschools : ModelBase
    {

        public ModelCharacterCraftschools()
        {

            Items = new List<string>();

        }

        [XmlElement(ElementName = "craftschool")]
        [DefaultValue(null)]
        public List<string> Items { get; set; }

    }

}
