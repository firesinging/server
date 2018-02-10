using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.enums;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Character list character data model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "CharacterData")]
    public class ModelEmpireCharacterlistCharacterData
    {

        [XmlElement(ElementName = "characterID")]
        public long CharacterId { get; set; }

        [XmlElement(ElementName = "CivId")]
        public Civilizations CivId { get; set; }

        [XmlElement(ElementName = "Name")]
        [DefaultValue(null)]
        public string Name { get; set; }

        [XmlElement(ElementName = "Level")]
        public int Level { get; set; }

    }

}
