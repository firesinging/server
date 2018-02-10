using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.equipment
{

    /// <summary>
    /// Equipment ranks model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "ranks")]
    public class ModelEquipmentRanks
    {

        public ModelEquipmentRanks()
        {

            Items = new List<ModelEquipmentRank>();

        }

        [XmlElement(ElementName = "rank")]
        [DefaultValue(null)]
        public List<ModelEquipmentRank> Items { get; set; }

    }

}
