using Libraries.database.models.character;


namespace Libraries.character
{

    public class CharacterConfigs : ModelCharacterConfigs
    {

        public CharacterConfigs()
        {

        }

        /// <summary>
        /// Set character config value.
        /// </summary>
        /// <param name="key">The config type.</param>
        /// <param name="value">The config value.</param>
        public void Set(string key, string value)
        {

            ModelCharacterConfig Config = new ModelCharacterConfig { Key = key, Value = value };

            if (Items.ContainsKey(key))
            {

                Items[key] = Config;

            } else
            {

                Items.Add(key, Config);

            }
                
        }

    }

}