using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Settings model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Settings")]
    public class ModelPlayerSettings : ModelBase
    {

        public ModelPlayerSettings()
        {

            Settings = new List<ModelPlayerSetting>();

        }

        [XmlAttribute(AttributeName = "Version")]
        [DefaultValue(1)]
        public int Version { get; set; }

        [XmlElement(ElementName = "Setting")]
        [DefaultValue(null)]
        public List<ModelPlayerSetting> Settings { get; set; }        

    }

}
