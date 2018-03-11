using System;

using Libraries.enums;
using Libraries.character;
using Libraries.quest;
using Libraries.database;
using Libraries.database.models;
using Libraries.database.models.quest;
using Libraries.database.models.questlistdata;

using Libraries.helpers.random;


namespace Libraries.helpers.character
{

    public static class CharacterHelper
    {

        /// <summary>
        /// Generates random CharacterId
        /// </summary>
        /// <param name="counter">Counter of number of tries to generate a random character Id.</param>
        /// <returns>CharacterId</returns>
        public static long generateCharacterId(int counter = 0)
        {

            long Result = StaticRandom.NextLong();

            if (Database.Characters.Get(Result) != null)
            {

                if(counter < 100)
                {

                    counter++;

                    generateCharacterId(counter);

                }
                else
                {

                    throw new ArgumentException($"CharacterHelper::generateCharacterId - Can not generate random character Id after {counter} tries");
                }                

            }

            return Result;

        }

        /// <summary>
        /// Get random city scenario for civilization 
        /// </summary>
        /// <param name="civId">The civilization Id.</param>
        /// <returns>Path to city scenario</returns>
        public static string GetRandomCityScenario(Civilizations civId)
        {

            switch (civId)
            {

                case Civilizations.Greek:

                    return $"Capitals/CAPITAL_C01_0{StaticRandom.Next(1, 6)}";

                case Civilizations.Egypt:

                    return $"Capitals/CAPITAL_C02_0{StaticRandom.Next(1, 6)}";


                case Civilizations.Celt:

                    return $"Capitals/CAPITAL_C03_0{StaticRandom.Next(1, 6)}";

                case Civilizations.Persia:

                    return $"Capitals/CAPITAL_C04_0{StaticRandom.Next(1, 3)}";

                case Civilizations.Babylonian:

                    return $"Capitals/CAPITAL_C06_0{StaticRandom.Next(1, 3)}";


                case Civilizations.Norse:

                    return $"Capitals/CAPITAL_C07_0{StaticRandom.Next(1, 3)}";

                default:

                    throw new ArgumentOutOfRangeException($"CharacterHelper::getRandomCityScenario - Unknown CivId. CivId: {civId}");

            }                   

        }

        /// <summary>
        /// Get character quest list data.
        /// </summary>
        /// <param name="objCharacter">The character.</param>
        /// <returns>ModelQuestListData.</returns>
        public static ModelQuestListData GetListdata(Character objCharacter)
        {

            //@TODO
            //Filter quests

            ModelQuestListData ObjListdata = new ModelQuestListData();

            foreach (Quest ObjQuest in Database.Quests.Values)
            {

                ModelQuestListNetDataCharacterIds Characterids = new ModelQuestListNetDataCharacterIds();

                foreach (ModelQuestPlayersettings Setting in ObjQuest.Playersettings)
                {

                    Characterids.Characterid.Add(0);

                }

                ModelQuestListNetData ObjQuestListNetData = new ModelQuestListNetData
                {

                    Prereqs = 1,                    
                    PrereqsInvalidated = 0,
                    Characterids = Characterids,
                    Filename = ObjQuest.Source

                };

                ObjListdata.QuestNetdata.Add(ObjQuestListNetData);

            }

            return ObjListdata;

        }

    }

}