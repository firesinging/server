using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Setting model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Setting")]
    public class ModelPlayerSetting
    {

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlText]
        [DefaultValue(null)]
        public string Text { get; set; }

    }

}
