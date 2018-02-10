using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Game currencys model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "GameCurrencys")]
    public class ModelPlayerGamecurrencys : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelPlayerGamecurrencys()
        {

            Items = new Dictionary<string, ModelPlayerGamecurrency>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelPlayerGamecurrency> Items { get; private set; }

        [XmlElement(ElementName = "gamecurrency")]
        public ModelPlayerGamecurrency[] ModelPlayerGamecurrency
        {

            get
            {

                List<ModelPlayerGamecurrency> List = new List<ModelPlayerGamecurrency>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, ModelPlayerGamecurrency>();

                if (value != null)
                {

                    foreach (ModelPlayerGamecurrency Item in value)
                    {

                        Items.Add(Item.Currencytype, Item);

                    }

                }

            }

        }

    }

}