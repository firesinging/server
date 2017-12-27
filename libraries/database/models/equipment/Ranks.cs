using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models
{

    /// <summary>
    /// Ranks model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ranks")]
    public class ModelEquipmentRanks
    {

        [XmlElement(ElementName = "rank")]
        public List<ModelEquipmentRank> Rank { get; set; }

    }

}
