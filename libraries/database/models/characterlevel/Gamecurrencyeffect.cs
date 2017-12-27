using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Gamecurrencyeffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gamecurrencyeffect")]
    public class ModelCharacterlevelGamecurrencyeffect
    {

        [XmlElement(ElementName = "empirepoints")]
        public string Empirepoints { get; set; }

    }

}
