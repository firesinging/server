using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.database.models.nugget;


namespace Libraries.database.models
{
    /// <summary>
    /// Vendor model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "nugget")]
    public class ModelNugget
    {

        public ModelNugget()
        {

            Animnugget = new ModelNuggetAnimnugget();

        }

        [XmlElement(ElementName = "dbid")]
        public int Dbid { get; set; }

        [XmlElement(ElementName = "name")]
        [DefaultValue(null)]
        public string Name { get; set; }

        [XmlElement(ElementName = "weight")]
        public int Weight { get; set; }

        [XmlElement(ElementName = "rewardloottable")]
        [DefaultValue(null)]
        public string Rewardloottable { get; set; }

        [XmlElement(ElementName = "animnugget")]
        [DefaultValue(null)]
        public ModelNuggetAnimnugget Animnugget { get; set; }

    }

}
