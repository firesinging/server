using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Setting model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Setting")]
    public class ModelEmpireSetting
    {

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
