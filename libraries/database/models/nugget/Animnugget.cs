using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Libraries.database.models.nugget
{

    /// <summary>
    /// Equipment rank model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "animnugget")]
    public class ModelNuggetAnimnugget
    {

        public ModelNuggetAnimnugget()
        {

            Guardianunit = new List<ModelNuggetAnimnuggetGuardianunit>();

        }

        [XmlElement(ElementName = "nuggetunit")]
        [DefaultValue(null)]
        public string Nuggetunit { get; set; }

        [XmlElement(ElementName = "guardianrevivaltime")]
        public string Guardianrevivaltime { get; set; }

        [XmlElement(ElementName = "guardianunit")]
        [DefaultValue(null)]
        public List<ModelNuggetAnimnuggetGuardianunit> Guardianunit { get; set; }

        [XmlElement(ElementName = "stringid")]
        public int Stringid { get; set; }

        [XmlElement(ElementName = "rolloverstringid")]
        public int Rolloverstringid { get; set; }

    }

}
