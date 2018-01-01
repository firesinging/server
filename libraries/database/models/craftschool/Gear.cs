using System.Xml.Serialization;


namespace Libraries.database.models.craftschool
{

    /// <summary>
    /// Craftschool gear model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gear")]
    public class ModelCraftschoolGear
    {

        [XmlAttribute(AttributeName = "stringid")]
        public string Stringid { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
