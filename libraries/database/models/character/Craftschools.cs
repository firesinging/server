using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character craftschools model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "craftschools")]
    public class ModelCharacterCraftschools
    {

        [XmlElement(ElementName = "craftschool")]
        public List<string> Craftschool { get; set; }

    }

}
