using System;
using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.character;
using Libraries.database.models.empire;


namespace Libraries.database.models
{

    /// <summary>
    /// Empire model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Empire")]
    public class ModelEmpire : ModelBase
    {

        public ModelEmpire()
        {

            Offers = new ModelEmpireOffers();
            Characterlist = new ModelEmpireCharacterlist();
            Allianceinfo = new ModelEmpireAllianceinfo();

        }

        [XmlAttribute(AttributeName = "Id")]
        public long Id { get; set; }
        
        [XmlAttribute(AttributeName = "Version")]
        public int Version { get; set; }

        [XmlElement(ElementName = "LastLaunched")]
        [DefaultValue(null)]
        public string Lastlaunched { get; set; }

        [XmlElement(ElementName = "Lastsave")]
        public DateTime Lastsave = DateTime.UtcNow;

        [XmlElement(ElementName = "Offers")]
        public ModelEmpireOffers Offers { get; set; }

        [XmlElement(ElementName = "CharacterList")]
        public ModelEmpireCharacterlist Characterlist { get; set; }

        [XmlElement(ElementName = "AllianceInfo")]
        public ModelEmpireAllianceinfo Allianceinfo { get; set; }

        [XmlIgnore]
        public long CurrentCharacterid { get; set; }

        [XmlIgnore]
        public Character CurrentCharacter
        {

            get
            {

                return Database.Characters.Get(CurrentCharacterid);

            }

        }

    }

}
