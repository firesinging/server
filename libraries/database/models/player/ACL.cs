using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.enums;


namespace Libraries.database.models.player
{

    /// <summary>
    /// ACL model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Actionlevels")]
    public class ModelPlayerACLs : ModelBase
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelPlayerACLs()
        {

            Items = new List<PlayerACL>();

        }

        [XmlIgnore]
        public List<PlayerACL> Items { get; set; }

        [XmlText]
        public string Text
        {

            get
            {

                return string.Join(",", Items.Select(i => (int) i));

            }

            set
            {

                Items = new List<PlayerACL>();

                if (value != null)
                {

                    foreach (var Item in value.Split(','))
                    {

                        Items.Add((PlayerACL)Enum.Parse(typeof(PlayerACL), Item));

                    }

                }                
                    
            }

        }  

    }

}
