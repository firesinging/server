using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.helpers.general;


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

        [XmlIgnore]
        public List<int> Items { get; set; }

        [XmlText]
        public string Text
        {

            get
            {

                return string.Join(",", Items);

            }

            set
            {

                Items = new List<int>();

                if (value != null)
                {

                    foreach (var Item in value.Split(','))
                    {

                        Items.Add(Convert.ToInt32(Item));

                    }

                }

            }

        }

        new public string ToXml
        {

            get
            {

                return $"<unlockedregions>{Convert.ToBase64String(Helper.ConvertListToBytes(Items))}</unlockedregions>";

            }

        }

    }

}
