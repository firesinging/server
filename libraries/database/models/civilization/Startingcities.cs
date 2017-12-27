using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models
{

    /// <summary>
    /// Starting cities model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "startingcities")]
    public class ModelCivilizationStartingcities
    {

        [XmlElement(ElementName = "startingcity")]
        public List<ModelCivilizationStartingcity> Startingcity { get; set; }

    }

}
