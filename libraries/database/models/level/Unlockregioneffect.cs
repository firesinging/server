using System.Xml.Serialization;


namespace Libraries.database.models.characterlevel
{

    /// <summary>
    /// Level unlockregioneffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unlockregioneffect")]
    public class ModelLevelUnlockregioneffect
    {

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

    }

}
