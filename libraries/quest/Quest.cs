using System.Xml.Serialization;

using Libraries.database.models;


namespace Libraries.quest
{

    [XmlRoot(ElementName = "quest")]
    public class Quest : ModelQuest
    {

        public Quest()
        {

        }

        /// <summary>
        /// Check if quest is based on random map.
        /// </summary>
        /// <returns>True if quest is based on random map.</returns>
        public bool IsRandomMap()
        {

            return (Randommap.Randommap.ToLower() == "true") ? true : false;

        }

        /// <summary>
        /// Generate random nuggets XML for quest.
        /// </summary>
        /// <param name="characterLevel">The current character level.</param>
        /// <returns>Random nugget XML.</returns>
        public string GetNuggets(int characterLevel)
        {

            //@TODO
            //
            // Empty nugget
            //
            //return "<Nuggets />";

            //
            // Filled nugget
            //
            return "<Nuggets><QuestId>11001</QuestId><NInst>3101,3101,3101,3101,3101</NInst></Nuggets>";

            // mapregionname in quest file -> nuggetlogic
            // Nuggets -> definition
            // Generate 5 random nugget installments based on criteria
            // Model: ModelQuestNuggetdata


        }









    }

}