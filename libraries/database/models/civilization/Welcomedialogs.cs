using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization welcome dialogs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "welcomedialogs")]
    public class ModelCivilizationWelcomedialogs
    {

        [XmlElement(ElementName = "firstquest")]
        public string Firstquest { get; set; }

        [XmlElement(ElementName = "greeting")]
        public ModelCivilizationGreeting Greeting { get; set; }

        [XmlElement(ElementName = "skiptutorialgreeting")]
        public string Skiptutorialgreeting { get; set; }

        [XmlElement(ElementName = "welcomedialogbackground")]
        public string Welcomedialogbackground { get; set; }

    }

}
