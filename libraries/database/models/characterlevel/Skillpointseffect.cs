using System.Xml.Serialization;


namespace Libraries.database.models.characterlevel
{

    /// <summary>
    /// Character level skillpointseffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "skillpointseffect")]
    public class ModelCharacterlevelSkillpointseffect
    {

        [XmlElement(ElementName = "skillpoints")]
        public int Skillpoints { get; set; }

    }

}
