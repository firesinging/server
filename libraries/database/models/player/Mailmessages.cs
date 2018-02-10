using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.player
{

    /// <summary>
    /// Mail messages model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "MailMessages")]
    public class ModelPlayerMailmessages : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelPlayerMailmessages()
        {

            Items = new Dictionary<long, ModelPlayerMailmessage>();

        }

        [XmlIgnore]
        public Dictionary<long, ModelPlayerMailmessage> Items { get; private set; }

        [XmlAttribute(AttributeName = "totalmail")]
        public int Totalmail
        {

            get
            {

                return Items.Count;

            }

        }

        [XmlAttribute(AttributeName = "nextmsgid")]
        public long Nextmsgid { get; set; }

        [XmlElement(ElementName = "message")]
        public ModelPlayerMailmessage[] ModelPlayerMailmessage
        {

            get
            {

                List<ModelPlayerMailmessage> List = new List<ModelPlayerMailmessage>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<long, ModelPlayerMailmessage>();

                if (value != null)
                {

                    foreach (ModelPlayerMailmessage Item in value)
                    {

                        Items.Add(Item.Messageid, Item);

                    }

                }

            }

        }

    }

}
