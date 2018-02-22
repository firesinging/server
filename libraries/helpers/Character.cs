using System;

using Libraries.enums;
using Libraries.logger;
using Libraries.database;
using Libraries.database.models;

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

            RandomEx Random = new RandomEx();

            long Result = Random.NextLong();

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
        public static string getRandomCityScenario(Civilizations civId)
        {

            RandomEx r = new RandomEx();

            switch (civId)
            {

                case Civilizations.Greek:

                    return $"Capitals/CAPITAL_C01_0{r.Next(1, 6)}";

                case Civilizations.Egypt:

                    return $"Capitals/CAPITAL_C02_0{r.Next(1, 6)}";


                case Civilizations.Celt:

                    return $"Capitals/CAPITAL_C03_0{r.Next(1, 6)}";

                case Civilizations.Persia:

                    return $"Capitals/CAPITAL_C04_0{r.Next(1, 3)}";

                case Civilizations.Babylonian:

                    return $"Capitals/CAPITAL_C06_0{r.Next(1, 3)}";


                case Civilizations.Norse:

                    return $"Capitals/CAPITAL_C07_0{r.Next(1, 3)}";

                default:

                    throw new ArgumentOutOfRangeException($"CharacterHelper::getRandomCityScenario - Unknown CivId. CivId: {civId}");

            }                   

        }

        /// <summary>
        /// Get character maximum XP for current character level.
        /// </summary>
        /// <param name="level">The character level.</param>
        /// <returns>Maximum XP for current character level.</returns>
        public static int GetMaximumXPforLevel(int level)
        {

            ModelCharacterLevel Level = Database.CharacterLevels[level + 1];
            ModelCharacterLevel MaxLevel = Database.CharacterLevels[Database.CharacterLevels.Count - 1];

            return (level < MaxLevel.Level) ? Level.Xp : MaxLevel.Xp;

        }

    }

}