using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Alliance info model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "AllianceInfo")]
    public class ModelEmpireAllianceinfo : ModelBase
    {

        [XmlElement(ElementName = "CurrentAlliance")]
        [DefaultValue(null)]
        public string CurrentAlliance { get; set; }


    }

}
