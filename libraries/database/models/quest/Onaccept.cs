using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.database.models.quest.onaccept;


namespace Libraries.database.models.quest
{

    /// <summary>
    /// Onaccept model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "onaccept")]
    public class ModelQuestOnaccept
    {

        [XmlElement(ElementName = "unlockequipment")]
        public ModelQuestOnacceptUnlockequipment Unlockequipment { get; set; }

        [XmlElement(ElementName = "protip")]
        public List<ModelQuestOnacceptProtip> Protip { get; set; }        

        [XmlElement(ElementName = "unlockregion")]
        public List<ModelQuestOnacceptUnlockRegion> UnlockRegion { get; set; }

        [XmlElement(ElementName = "blueprint")]
        public List<ModelQuestOnacceptBlueprint> Blueprint { get; set; }

        [XmlElement(ElementName = "enableprotip")]
        public List<ModelQuestOnacceptEnableprotip> Enableprotip { get; set; }

        [XmlElement(ElementName = "questgiver")]
        public List<ModelQuestOnacceptQuestgiver> Questgiver { get; set; }

    }

}
