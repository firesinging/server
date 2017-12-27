using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models
{

    /// <summary>
    /// Wall model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "scenariobaseunits")]
    public class ModelCivilizationScenariobaseunits
    {

        [XmlElement(ElementName = "baseunit")]
        public List<string> Baseunit { get; set; }

    }

}
