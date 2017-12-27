using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Unlockregioneffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unlockregioneffect")]
    public class ModelCharacterlevelUnlockregioneffect
    {

        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

    }

}
