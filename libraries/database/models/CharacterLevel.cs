using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.database.models.characterlevel;


namespace Libraries.database.models
{
    /// <summary>
    /// CharacterLevel model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "level")]
    public class ModelCharacterLevel
    {

        [XmlIgnore]
        public int Level { get; set; }

        [XmlElement(ElementName = "xp")]
        public int Xp { get; set; }

        [XmlElement(ElementName = "gamecurrencyeffect")]
        public ModelCharacterlevelGamecurrencyeffect Gamecurrencyeffect { get; set; }

        [XmlElement(ElementName = "skillpointseffect")]
        public ModelCharacterlevelSkillpointseffect Skillpointseffect { get; set; }

        [XmlElement(ElementName = "ageupeffect")]
        public ModelCharacterlevelAgeupeffect Ageupeffect { get; set; }

        [XmlElement(ElementName = "unlockregioneffect")]
        public List<ModelCharacterlevelUnlockregioneffect> Unlockregioneffect { get; set; }

    }

}
