using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Empire model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Empire")]
    public class ModelEmpireEmpire
    {

        [XmlElement(ElementName = "LastLaunched")]
        public string Lastlaunched { get; set; }

        [XmlElement(ElementName = "Offers")]
        public ModelEmpireEmpireOffers Offers { get; set; }

        [XmlElement(ElementName = "CharacterList")]
        public ModelEmpireEmpireCharacterlist Characterlist { get; set; }

        [XmlElement(ElementName = "AllianceInfo")]
        public ModelEmpireEmpireAllianceinfo Allianceinfo { get; set; }

    }

}
