using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Mail message items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "items")]
    [DefaultValue(null)]
    public class ModelPlayerMailmessageItems
    {

        public ModelPlayerMailmessageItems()
        {

            Item = new ModelPlayerMailmessageItem();

        }

        [XmlElement(ElementName = "item")]
        [DefaultValue(null)]
        public ModelPlayerMailmessageItem Item { get; set; }

    }

}
