using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Character list model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "CharacterList")]
    public class ModelEmpireEmpireCharacterlist
    {
        
        [XmlElement(ElementName = "CharacterData")]
        public List<ModelEmpireEmpireCharacterlistCharacterData> CharacterData { get; set; }
        
    }

}
