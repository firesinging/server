using System.Xml.Serialization;


namespace Libraries.database.models.characterlevel
{

    /// <summary>
    /// Level skillpointseffect model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "skillpointseffect")]
    public class ModelLevelSkillpointseffect
    {

        [XmlElement(ElementName = "skillpoints")]
        public int Skillpoints { get; set; }

    }

}
