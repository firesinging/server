using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

using Libraries.helpers.region;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character regions unlocked model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "unlockedregions")]
    public class ModelCharacterUnlockedRegions : ModelBase
    {

        public ModelCharacterUnlockedRegions()
        {

            Items = new List<int>();

        }

        [XmlElement(ElementName = "unlockedregion")]
        [DefaultValue(null)]
        public List<int> Items { get; set; }

        new public string ToXml
        {

            get
            {

                return string.Format("<unlockedregions>{0}</unlockedregions>", RegionHelper.ConvertListToBase64String(Items));

            }

        }

    }

}
