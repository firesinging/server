using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models.nuggetlogic
{

    /// <summary>
    /// Nugget logic quest level model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questlevel")]
    public class ModelNuggetLogicQuestlevel
    {

        [XmlElement(ElementName = "nuggetref")]
        [DefaultValue(null)]
        public List<string> Nuggetref { get; set; }

        [XmlAttribute(AttributeName = "minlevel")]
        public int Minlevel { get; set; }

        [XmlAttribute(AttributeName = "maxlevel")]
        public int Maxlevel { get; set; }

    }

}
