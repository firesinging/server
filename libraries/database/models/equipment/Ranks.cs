using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.equipment
{

    /// <summary>
    /// Equipment ranks model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ranks")]
    public class ModelEquipmentRanks
    {

        [XmlElement(ElementName = "rank")]
        public List<ModelEquipmentRank> Rank { get; set; }

    }

}
