using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.quest.objectives
{

    /// <summary>
    /// Criteria model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "values")]
    public class ModelQuestObjectivesCriteria
    {

        [XmlElement(ElementName = "timer")]
        public ModelQuestObjectivesTimer Timer { get; set; }

        [XmlElement(ElementName = "buildunit")]
        public List<ModelQuestObjectivesBuildunit> Buildunit { get; set; }

        [XmlElement(ElementName = "population")]
        public List<ModelQuestObjectivesPopulation> Population { get; set; }

        [XmlElement(ElementName = "repairunit")]
        public List<ModelQuestObjectivesRepairunit> Repairunit { get; set; }

        [XmlElement(ElementName = "unitinarea")]
        public List<ModelQuestObjectivesUnitinarea> Unitinarea { get; set; }

        [XmlElement(ElementName = "unitnearunit")]
        public List<ModelQuestObjectivesUnitnearunit> Unitnearunit { get; set; }

        [XmlElement(ElementName = "unitdiscovered")]
        public List<ModelQuestObjectivesUnitdiscovered> Unitdiscovered { get; set; }

        [XmlElement(ElementName = "ownsunit")]
        public List<ModelQuestObjectivesOwnsunit> Ownsunit { get; set; }

        [XmlElement(ElementName = "protectunit")]
        public List<ModelQuestObjectivesProtectunit> Protectunit { get; set; }

        [XmlElement(ElementName = "convertunit")]
        public List<ModelQuestObjectivesConvertunit> Convertunit { get; set; }

        [XmlElement(ElementName = "kill")]
        public List<ModelQuestObjectivesKill> Kill { get; set; }

        [XmlElement(ElementName = "reduceunitsto")]
        public List<ModelQuestObjectivesReduceunitsto> Reduceunitsto { get; set; }

        [XmlElement(ElementName = "counter")]
        public List<ModelQuestObjectivesCounter> Counter { get; set; }

        [XmlElement(ElementName = "collectmaterial")]
        public List<ModelQuestObjectivesCollectmaterial> Collectmaterial { get; set; }

        [XmlElement(ElementName = "collectresource")]
        public List<ModelQuestObjectivesCollectresource> Collectresource { get; set; }

        [XmlElement(ElementName = "tribute")]
        public List<ModelQuestObjectivesTribute> Tribute { get; set; }

        [XmlElement(ElementName = "queststatus")]
        public List<ModelQuestObjectivesQueststatus> Queststatus { get; set; }       

        [XmlElement(ElementName = "completegame")]
        public List<ModelQuestObjectivesCompletegame> Completegame { get; set; } 

        [XmlElement(ElementName = "techstatus")]
        public List<ModelQuestObjectivesTechstatus> Techstatus { get; set; }

        [XmlElement(ElementName = "wingame")]
        public List<ModelQuestObjectivesWingame> Wingame { get; set; }

        [XmlElement(ElementName = "ownsequipment")]
        public List<ModelQuestObjectivesOwnsequipment> Ownsequipment { get; set; }

        [XmlElement(ElementName = "dummy")]
        public List<ModelQuestObjectivesDummy> Dummy { get; set; }

        [XmlElement(ElementName = "and")]
        public List<ModelQuestObjectivesAnd> And { get; set; }

        [XmlElement(ElementName = "or")]
        public List<ModelQuestObjectivesOr> Or { get; set; }

    }

}
