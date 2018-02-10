using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

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

        public ModelQuestOnaccept()
        {

            Protip = new List<ModelQuestOnacceptProtip>();
            UnlockRegion = new List<ModelQuestOnacceptUnlockRegion>();
            Blueprint = new List<ModelQuestOnacceptBlueprint>();
            Enableprotip = new List<ModelQuestOnacceptEnableprotip>();
            Questgiver = new List<ModelQuestOnacceptQuestgiver>();

        }

        [XmlElement(ElementName = "unlockequipment")]
        public ModelQuestOnacceptUnlockequipment Unlockequipment { get; set; }

        [XmlElement(ElementName = "protip")]
        [DefaultValue(null)]
        public List<ModelQuestOnacceptProtip> Protip { get; set; }        

        [XmlElement(ElementName = "unlockregion")]
        [DefaultValue(null)]
        public List<ModelQuestOnacceptUnlockRegion> UnlockRegion { get; set; }

        [XmlElement(ElementName = "blueprint")]
        [DefaultValue(null)]
        public List<ModelQuestOnacceptBlueprint> Blueprint { get; set; }

        [XmlElement(ElementName = "enableprotip")]
        [DefaultValue(null)]
        public List<ModelQuestOnacceptEnableprotip> Enableprotip { get; set; }

        [XmlElement(ElementName = "questgiver")]
        [DefaultValue(null)]
        public List<ModelQuestOnacceptQuestgiver> Questgiver { get; set; }

    }

}
