using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Mail message items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "items")]
    public class ModelEmpireMailmessageItems
    {

        [XmlElement(ElementName = "item")]
        public ModelEmpireMailmessageItem Item { get; set; }

    }

}
