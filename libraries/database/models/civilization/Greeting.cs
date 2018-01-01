using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization greeting model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "greeting")]
    public class ModelCivilizationGreeting
    {

        [XmlAttribute(AttributeName = "showleveleffectonclose")]
        public string Showleveleffectonclose { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
