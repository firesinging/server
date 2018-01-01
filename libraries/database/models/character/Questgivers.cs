using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character questgivers model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questgivers")]
    public class ModelCharacterQuestgivers
    {

        [XmlElement(ElementName = "questgiver")]
        public List<ModelCharacterQuestgiver> Questgiver { get; set; }

    }

}
