using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.database.models.nuggetlogic;


namespace Libraries.database.models
{
    /// <summary>
    /// Nugget logic model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "randommapregion")]
    public class ModelNuggetLogic
    {

        public ModelNuggetLogic()
        {

            Questlevel = new List<ModelNuggetLogicQuestlevel>();

        }

        [XmlElement(ElementName = "questlevel")]
        [DefaultValue(null)]
        public List<ModelNuggetLogicQuestlevel> Questlevel { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

    }

}
