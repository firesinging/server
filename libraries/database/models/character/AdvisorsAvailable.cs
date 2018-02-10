using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character available advisors model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "availableadvisors")]
    public class ModelCharacterAdvisorsAvailable : ModelBase
    {

        public ModelCharacterAdvisorsAvailable()
        {

            Items = new List<string>();

        }

        [XmlElement(ElementName = "availableadvisor")]
        [DefaultValue(null)]
        public List<string> Items { get; set; }

    }

}
