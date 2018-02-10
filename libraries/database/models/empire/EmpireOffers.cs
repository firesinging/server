using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

using Libraries.enums;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Empire offers model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Offers")]
    public class ModelEmpireOffers
    {

        public ModelEmpireOffers()
        {

            Items = new List<OfferTypes>();

        }

        [XmlElement(ElementName = "OfferType")]
        [DefaultValue(null)]
        public List<OfferTypes> Items { get; set; }

    }

}
