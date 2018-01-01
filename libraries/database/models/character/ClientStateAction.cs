using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character clientstate action model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "action")]
    public class ModelCharacterClientStateAction
    {

        [XmlAttribute(AttributeName = "trainpoints")]
        public string Trainpoints { get; set; }

        [XmlAttribute(AttributeName = "actiontype")]
        public string Actiontype { get; set; }

        [XmlAttribute(AttributeName = "actionname")]
        public string Actionname { get; set; }

    }

}
