using System.Xml.Serialization;


namespace Libraries.database.models.vendor
{

    /// <summary>
    /// Itemsets model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "itemsets")]
    public class ModelVendorItemsets
    {

        [XmlElement(ElementName = "itemset")]
        public ModelVendorItemset Itemset { get; set; }

    }

}
