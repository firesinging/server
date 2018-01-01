using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.database.models.quest.rewards;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Secondaryrewards model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "secondaryrewards")]
    public class ModelQuestSecondaryrewards
    {

        [XmlElement(ElementName = "capitalresource")]
        public ModelQuestRewardsCapitalresource Capitalresource { get; set; }

        [XmlElement(ElementName = "loottable")]
        public List<ModelQuestRewardsLoottable> Loottable { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

    }

}
