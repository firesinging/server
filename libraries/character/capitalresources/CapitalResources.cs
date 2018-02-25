using Libraries.database.models.character;


namespace Libraries.character
{

    public class CharacterCapitalResources : ModelCharacterCapitalResources
    {

        public CharacterCapitalResources()
        {

        }

        /// <summary>
        /// Get character capital resource value.
        /// </summary>
        /// <param name="type">The capital resource type.</param>
        /// <returns>Character capital resource value or default quantity.</returns>
        public double GetResource(string type)
        {

            return Items.TryGetValue(type, out ModelCharacterCapitalResource Item) ? Item.Quantity : 0;

        }

    }

}