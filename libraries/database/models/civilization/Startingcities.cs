using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization starting cities model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "startingcities")]
    public class ModelCivilizationStartingcities
    {

        public ModelCivilizationStartingcities()
        {

            Startingcity = new List<ModelCivilizationStartingcity>();

        }

        [XmlElement(ElementName = "startingcity")]
        [DefaultValue(null)]
        public List<ModelCivilizationStartingcity> Startingcity { get; set; }

    }

}
