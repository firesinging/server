using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization starting city model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "startingcity")]
    public class ModelCivilizationStartingcity
    {

        [XmlElement(ElementName = "cityname")]
        [DefaultValue(null)]
        public string Cityname { get; set; }

        [XmlElement(ElementName = "scenariobaseunits")]
        public ModelCivilizationScenariobaseunits Scenariobaseunits { get; set; }
    }

}
