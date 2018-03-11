using System.IO;
using System.Linq;
using System.Collections.Generic;

using Libraries.enums;
using Libraries.quest;
using Libraries.database;
using Libraries.database.models;
using Libraries.database.models.quest.instance;

using Libraries.helpers.xml;
using Libraries.helpers.pathing;
using Libraries.helpers.quest;


namespace Libraries.helpers.database
{

    public static class DatabaseHelper
    {

        /// <summary>
        /// Linq exclude directories criteria 
        /// </summary>
        /// <param name="exludedDirList">Directory list to exclude</param>
        /// <param name="f">The filename</param>
        /// <returns></returns>
        public static bool IsExcluded(List<string> exludedDirList, string f)
        {

            return exludedDirList.Any(d => Path.GetFileName(Path.GetDirectoryName(f)).Equals(d));

        }

        /// <summary>
        /// Deserialize game files from database 
        /// </summary>
        /// <param name="f">The filename</param>
        /// <returns></returns>
        public static T Deserialize<T>(string f) where T : new()
        {

            T Instance = new T().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}{f}");

            return (T)Instance;

        }

        /// <summary>
        /// Get quest instance from quest.
        /// </summary>
        /// <param name="q">The quest.</param>
        /// <returns>Quest instance.</returns>
        public static QuestInstance GetQuestInstance(Quest q)
        {

            QuestInstance ObjInstance = new QuestInstance()
            {

                Id = q.Id,
                Status = "assigned",
                Scale = q.Questbasescale,
                Timer = q.Timer,
                Giveregion = q.GiveRegion,
                Returnregion = q.ReturnRegion,
                Active = ((q.Questtype == QuestTypes.CapitolCity) || (q.Questtype == QuestTypes.Global)) ? "true" : "false",
                Objective = new ModelQuestinstanceObjective() { Id = q.Objectives.Id, Type = "And", MustFailAll = q.Objectives.Mustfailall, Objective = QuestHelper.ConvertQuestObjectiveValues(q.Objectives.Values) },
                Secondaryobjectives = QuestHelper.ConvertQuestSecondaryobjectivesValues(q)

            };

            return ObjInstance;

        }

        public static int MaxCharacterlevel()
        {

            return Database.Levels[Database.Levels.Count - 1].Level;

        }

        /// <summary>
        /// Maximum XP for level.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <returns>Maximum XP for the level.</returns>
        public static int GetMaximumXPforLevel(int level)
        {

            ModelLevel Level = Database.Levels[level + 1];
            ModelLevel MaxLevel = Database.Levels[Database.Levels.Count - 1];

            return (level < MaxLevel.Level) ? Level.Xp : MaxLevel.Xp;

        }

    }

}
