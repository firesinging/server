using System.Xml.Serialization;


namespace Libraries.database.models.characterlevel
{

    /// <summary>
    /// Character level gamecurrencyeffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gamecurrencyeffect")]
    public class ModelCharacterlevelGamecurrencyeffect
    {

        [XmlElement(ElementName = "empirepoints")]
        public int Empirepoints { get; set; }

    }

}
