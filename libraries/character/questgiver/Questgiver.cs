using Libraries.database.models.character;

namespace Libraries.character
{

    public class CharacterQuestgiver : ModelCharacterQuestgiver
    {

        public CharacterQuestgiver()
        {

        }

        /// <summary>
        /// Check if questgiver is available.
        /// </summary>
        /// <returns>True if questgiver is available.</returns>
        public bool IsAvailable()
        {

            if (Status.ToLower() == "available")
            {

                return true;

            }

            return false;

        }

    }

}
