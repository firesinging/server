using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Skillpointseffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "skillpointseffect")]
    public class ModelCharacterlevelSkillpointseffect
    {

        [XmlElement(ElementName = "skillpoints")]
        public string Skillpoints { get; set; }

    }

}
