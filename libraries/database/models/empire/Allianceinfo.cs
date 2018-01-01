using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Alliance info model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "AllianceInfo")]
    public class ModelEmpireEmpireAllianceinfo
    {

        [XmlElement(ElementName = "CurrentAlliance")]
        public string CurrentAlliance { get; set; }


    }

}
