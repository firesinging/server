using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character learned designs model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "learneddesigns")]
    public class ModelCharacterLearneddesigns
    {

        public ModelCharacterLearneddesigns()
        {

            Learneddesign = new List<string>();

        }

        [XmlElement(ElementName = "learneddesign")]
        public List<string> Learneddesign { get; set; }

    }

}
