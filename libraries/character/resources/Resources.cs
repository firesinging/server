using Libraries.database.models.character;


namespace Libraries.character
{

    public class CharacterResources : ModelCharacterResources
    {

        public CharacterResources()
        {

        }

        /// <summary>
        /// Get character resource value.
        /// </summary>
        /// <param name="type">The resource type.</param>
        /// <returns>Character resource value or default quantity.</returns>
        public int GetResource(string type)
        {

            return Items.TryGetValue(type, out ModelCharacterResource Item) ? Item.Quantity : 0;

        }

        /// <summary>
        /// Set character resource value.
        /// </summary>
        /// <param name="type">The resource type.</param>
        /// <returns>Character resource value or default quantity.</returns>
        public void SetResource(string type, int quantity)
        {

            if (Items.TryGetValue(type, out ModelCharacterResource Item))
            {

                Item.Quantity = quantity;

            } else
            {

                Items.Add(type, new ModelCharacterResource() { Resourcetype = type, Quantity = quantity });

            }

        }

    }

}