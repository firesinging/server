using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

using Libraries.database.models.characterlevel;


namespace Libraries.database.models
{
    /// <summary>
    /// CharacterLevel model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "level")]
    public class ModelLevel
    {

        public ModelLevel()
        {

            Unlockregioneffect = new List<ModelLevelUnlockregioneffect>();

        }        

        [XmlElement(ElementName = "xp")]
        public int Xp { get; set; }

        [XmlElement(ElementName = "gamecurrencyeffect")]
        public ModelLevelGamecurrencyeffect Gamecurrencyeffect { get; set; }

        [XmlElement(ElementName = "skillpointseffect")]
        public ModelLevelSkillpointseffect Skillpointseffect { get; set; }

        [XmlElement(ElementName = "ageupeffect")]
        public ModelLevelAgeupeffect Ageupeffect { get; set; }

        [XmlElement(ElementName = "unlockregioneffect")]
        [DefaultValue(null)]
        public List<ModelLevelUnlockregioneffect> Unlockregioneffect { get; set; }

        [XmlIgnore]
        public int Level { get; set; }

    }

}
