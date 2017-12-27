using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Starting city model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "startingcity")]
    public class ModelCivilizationStartingcity
    {

        [XmlElement(ElementName = "cityname")]
        public string Cityname { get; set; }

        [XmlElement(ElementName = "scenariobaseunits")]
        public ModelCivilizationScenariobaseunits Scenariobaseunits { get; set; }
    }

}
