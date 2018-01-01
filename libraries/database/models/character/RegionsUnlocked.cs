using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character regions unlocked model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unlockedregions")]
    public class ModelCharacterUnlockedRegions
    {

        [XmlElement(ElementName = "unlockedregions")]
        public List<string> Unlockedregions { get; set; }

    }

}
