using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character available advisors model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "availableadvisors")]
    public class ModelCharacterAdvisorsAvailable
    {

        [XmlElement(ElementName = "availableadvisor")]
        public List<string> Availableadvisor { get; set; }

    }

}
