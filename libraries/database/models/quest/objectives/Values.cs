using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Values model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "values")]
    public class ModelQuestObjectivesValues
    {

        public ModelQuestObjectivesValues()
        {

            Timer = new List<ModelQuestObjectivesTimer>();
            Buildunit = new List<ModelQuestObjectivesBuildunit>();
            Population = new List<ModelQuestObjectivesPopulation>();
            Repairunit = new List<ModelQuestObjectivesRepairunit>();
            Unitinarea = new List<ModelQuestObjectivesUnitinarea>();
            Unitnearunit = new List<ModelQuestObjectivesUnitnearunit>();
            Unitdiscovered = new List<ModelQuestObjectivesUnitdiscovered>();
            Ownsunit = new List<ModelQuestObjectivesOwnsunit>();
            Protectunit = new List<ModelQuestObjectivesProtectunit>();
            Convertunit = new List<ModelQuestObjectivesConvertunit>();
            Kill = new List<ModelQuestObjectivesKill>();
            Reduceunitsto = new List<ModelQuestObjectivesReduceunitsto>();
            Counter = new List<ModelQuestObjectivesCounter>();
            Collectmaterial = new List<ModelQuestObjectivesCollectmaterial>();
            Collectresource = new List<ModelQuestObjectivesCollectresource>();
            Tribute = new List<ModelQuestObjectivesTribute>();
            Queststatus = new List<ModelQuestObjectivesQueststatus>();
            Completegame = new List<ModelQuestObjectivesCompletegame>();
            Techstatus = new List<ModelQuestObjectivesTechstatus>();
            Wingame = new List<ModelQuestObjectivesWingame>();
            Ownsequipment = new List<ModelQuestObjectivesOwnsequipment>();
            Dummy = new List<ModelQuestObjectivesDummy>();
            And = new List<ModelQuestObjectivesAnd>();
            Or = new List<ModelQuestObjectivesOr>();

        }

        [XmlElement(ElementName = "timer")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesTimer> Timer { get; set; }

        [XmlElement(ElementName = "buildunit")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesBuildunit> Buildunit { get; set; }

        [XmlElement(ElementName = "population")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesPopulation> Population { get; set; }

        [XmlElement(ElementName = "repairunit")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesRepairunit> Repairunit { get; set; }

        [XmlElement(ElementName = "unitinarea")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesUnitinarea> Unitinarea { get; set; }

        [XmlElement(ElementName = "unitnearunit")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesUnitnearunit> Unitnearunit { get; set; }

        [XmlElement(ElementName = "unitdiscovered")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesUnitdiscovered> Unitdiscovered { get; set; }

        [XmlElement(ElementName = "ownsunit")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesOwnsunit> Ownsunit { get; set; }

        [XmlElement(ElementName = "protectunit")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesProtectunit> Protectunit { get; set; }

        [XmlElement(ElementName = "convertunit")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesConvertunit> Convertunit { get; set; }

        [XmlElement(ElementName = "kill")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesKill> Kill { get; set; }

        [XmlElement(ElementName = "reduceunitsto")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesReduceunitsto> Reduceunitsto { get; set; }

        [XmlElement(ElementName = "counter")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesCounter> Counter { get; set; }

        [XmlElement(ElementName = "collectmaterial")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesCollectmaterial> Collectmaterial { get; set; }

        [XmlElement(ElementName = "collectresource")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesCollectresource> Collectresource { get; set; }

        [XmlElement(ElementName = "tribute")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesTribute> Tribute { get; set; }

        [XmlElement(ElementName = "queststatus")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesQueststatus> Queststatus { get; set; }

        [XmlElement(ElementName = "completegame")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesCompletegame> Completegame { get; set; }

        [XmlElement(ElementName = "techstatus")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesTechstatus> Techstatus { get; set; }

        [XmlElement(ElementName = "wingame")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesWingame> Wingame { get; set; }

        [XmlElement(ElementName = "ownsequipment")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesOwnsequipment> Ownsequipment { get; set; }

        [XmlElement(ElementName = "dummy")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesDummy> Dummy { get; set; }

        [XmlElement(ElementName = "and")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesAnd> And { get; set; }

        [XmlElement(ElementName = "or")]
        [DefaultValue(null)]
        public List<ModelQuestObjectivesOr> Or { get; set; }

    }

}
