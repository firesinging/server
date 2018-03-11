using System.Xml.Serialization;


namespace Libraries.database.models.characterlevel
{

    /// <summary>
    /// Level gamecurrencyeffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gamecurrencyeffect")]
    public class ModelLevelGamecurrencyeffect
    {

        [XmlElement(ElementName = "empirepoints")]
        public int Empirepoints { get; set; }

    }

}
