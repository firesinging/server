using System.Xml.Serialization;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Game currency model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "gamecurrency")]
    public class ModelEmpireGamecurrency
    {

        [XmlAttribute(AttributeName = "currencytype")]
        public string Currencytype { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public int Quantity { get; set; }

    }

}
