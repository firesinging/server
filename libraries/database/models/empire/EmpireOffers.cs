using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.enums;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Empire offers model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Offers")]
    public class ModelEmpireEmpireOffers
    {

        [XmlElement(ElementName = "OfferType")]
        public List<OfferTypes> OfferType { get; set; }

    }

}
