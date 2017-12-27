using System.Xml.Serialization;


namespace Libraries.database.models
{

    /// <summary>
    /// Itemset model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "itemset")]
    public class ModelVendorItemset
    {

        [XmlElement(ElementName = "items")]
        public ModelVendorItems Items { get; set; }

        [XmlAttribute(AttributeName = "regionid")]
        public string Regionid { get; set; }

    }

}
