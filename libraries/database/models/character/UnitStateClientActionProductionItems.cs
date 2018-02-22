using System.Xml.Serialization;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character client unitstate action production items model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "productionitems")]
    public class ModelCharacterUnitStateClientActionProductionItems
    {

        [XmlElement(ElementName = "production")]
        [DefaultValue(null)]
        public ModelCharacterUnitStateClientActionProduction Production { get; set; }

    }

}
