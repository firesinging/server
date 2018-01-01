using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.empire
{

    /// <summary>
    /// Game currencys model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "GameCurrencys")]
    public class ModelEmpireGamecurrencys
    {

        [XmlElement(ElementName = "gamecurrency")]
        public List<ModelEmpireGamecurrency> Gamecurrency { get; set; }

    }

}
