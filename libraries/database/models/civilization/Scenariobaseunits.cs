using System.ComponentModel;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization wall model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "scenariobaseunits")]
    public class ModelCivilizationScenariobaseunits
    {

        public ModelCivilizationScenariobaseunits()
        {

            Items = new List<string>();

        }

        [XmlElement(ElementName = "baseunit")]
        [DefaultValue(null)]
        public List<string> Items { get; set; }

    }

}
