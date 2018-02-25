using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Generic loot roll model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "lootroll")]
    public class ModelGenericLootRoll
    {

        [XmlAttribute(AttributeName = "quantity")]
        public int Quantity { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
