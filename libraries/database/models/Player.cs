using System.Xml.Serialization;

using Libraries.helpers.player;


namespace Libraries.database.models
{

    /// <summary>
    /// Player model
    /// </summary>

    [XmlRoot(ElementName = "player")]
    public class ModelPlayer
    {

        [XmlAttribute(AttributeName = "Id")]
        public long Id { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Password")]
        public string Password
        {

            get
            {

                return this.Password;

            }

            set
            {

                if (string.IsNullOrEmpty(value))
                {

                    return;

                }

                PlayerHelper.CreateHash(value);

            }


        }

    }

}
