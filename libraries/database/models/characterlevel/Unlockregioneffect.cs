using System.Xml.Serialization;


namespace Libraries.database.models.characterlevel
{

    /// <summary>
    /// Character level unlockregioneffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unlockregioneffect")]
    public class ModelCharacterlevelUnlockregioneffect
    {

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

    }

}
