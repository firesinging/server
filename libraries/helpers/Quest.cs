using System.Linq;
using System.Collections.Generic;

using Libraries.quest;
using Libraries.database.models.quest.instance;
using Libraries.database.models.quest.objectives;


namespace Libraries.helpers.quest
{

    public static class QuestHelper
    {

        /// <summary>
        /// Convert quest secondary objective values to instance secondary objective values.
        /// </summary>
        /// <param name="quest">The quest.</param>
        /// <returns>ModelQuestInstance.</returns>
        public static List<ModelQuestinstanceObjective> ConvertQuestSecondaryobjectivesValues(Quest quest)
        {

            if ((quest.Secondaryobjectives != null) && (quest.Secondaryobjectives.Count > 0))
            {

                return quest.Secondaryobjectives.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "And", MustFailAll = i.Mustfailall, RewardName = i.Rewardname, Objective = ConvertQuestObjectiveValues(i.Values) });

            }

            return null;

        }

        /// <summary>
        /// Convert quest objective values to instance objective values.
        /// </summary>
        /// <param name="values">List objective values.</param>
        /// <returns>List of ModelQuestinstanceObjective.</returns>
        public static List<ModelQuestinstanceObjective> ConvertQuestObjectiveValues(ModelQuestObjectivesValues values)
        {

            List<ModelQuestinstanceObjective> ObjObjectives = new List<ModelQuestinstanceObjective>();

            if (values.Timer != null)
            {

                ObjObjectives.AddRange(values.Timer.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "Timer" }));

            }

            if (values.Buildunit != null)
            {

                ObjObjectives.AddRange(values.Buildunit.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "BuildUnit" }));

            }

            if (values.Population != null)
            {

                ObjObjectives.AddRange(values.Population.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "Population" }));

            }

            if (values.Repairunit != null)
            {

                ObjObjectives.AddRange(values.Repairunit.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "RepairUnit" }));

            }

            if (values.Unitinarea != null)
            {

                ObjObjectives.AddRange(values.Unitinarea.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "UnitInArea" }));

            }

            if (values.Unitnearunit != null)
            {

                ObjObjectives.AddRange(values.Unitnearunit.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "UnitNearUnit" }));

            }

            if (values.Unitdiscovered != null)
            {

                ObjObjectives.AddRange(values.Unitdiscovered.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "UnitDiscovered" }));

            }

            if (values.Ownsunit != null)
            {

                ObjObjectives.AddRange(values.Ownsunit.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "OwnsUnit" }));

            }

            if (values.Protectunit != null)
            {

                ObjObjectives.AddRange(values.Protectunit.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "ProtectUnit" }));

            }

            if (values.Convertunit != null)
            {

                ObjObjectives.AddRange(values.Convertunit.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "ConvertUnit" }));

            }

            if (values.Kill != null)
            {

                ObjObjectives.AddRange(values.Kill.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "Kill" }));

            }

            if (values.Reduceunitsto != null)
            {

                ObjObjectives.AddRange(values.Reduceunitsto.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "ReduceUnitsTo" }));

            }

            if (values.Counter != null)
            {

                ObjObjectives.AddRange(values.Counter.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "Counter" }));

            }

            if (values.Collectmaterial != null)
            {

                ObjObjectives.AddRange(values.Collectmaterial.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "CollectMaterial" }));

            }

            if (values.Collectresource != null)
            {

                ObjObjectives.AddRange(values.Collectresource.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "CollectResource" }));

            }

            if (values.Tribute != null)
            {

                ObjObjectives.AddRange(values.Tribute.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "Tribute" }));

            }

            if (values.Queststatus != null)
            {

                ObjObjectives.AddRange(values.Queststatus.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "QuestStatus" }));

            }

            if (values.Completegame != null)
            {

                ObjObjectives.AddRange(values.Completegame.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "CompleteGame" }));

            }

            if (values.Techstatus != null)
            {

                ObjObjectives.AddRange(values.Techstatus.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "TechStatus" }));

            }

            if (values.Wingame != null)
            {

                ObjObjectives.AddRange(values.Wingame.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "WinGame" }));

            }

            if (values.Ownsequipment != null)
            {

                ObjObjectives.AddRange(values.Ownsequipment.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "OwnsEquipment" }));

            }

            if (values.Dummy != null)
            {

                ObjObjectives.AddRange(values.Dummy.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "Dummy" }));

            }

            if (values.And != null)
            {

                ObjObjectives.AddRange(values.And.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "And", MustFailAll = i.Mustfailall, Objective = ConvertQuestObjectiveValues(i.Values) }));

            }

            if (values.Or != null)
            {

                ObjObjectives.AddRange(values.Or.ConvertAll(i => new ModelQuestinstanceObjective() { Id = i.Id, Type = "Or", MustFailAll = i.Mustfailall, Objective = ConvertQuestObjectiveValues(i.Values) }));

            }

            return ObjObjectives.OrderBy(orderby => orderby.Id).ToList();

        }





    }

}