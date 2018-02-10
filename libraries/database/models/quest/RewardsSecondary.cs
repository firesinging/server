using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

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

        public ModelQuestSecondaryrewards()
        {

            Loottable = new List<ModelQuestRewardsLoottable>();

        }

        [XmlElement(ElementName = "capitalresource")]
        public ModelQuestRewardsCapitalresource Capitalresource { get; set; }

        [XmlElement(ElementName = "loottable")]
        [DefaultValue(null)]
        public List<ModelQuestRewardsLoottable> Loottable { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

    }

}
