using System;
using System.Linq;

using Libraries.database.models;


namespace Libraries.character
{
    /// <summary>
    /// Characters library to maintain characters dictionary.
    /// </summary>
    public class Characters : ModelCharacters
    {

        public Characters()
        {

        }

        /// <summary>
        /// Total number of characters.
        /// </summary>
        public int Total => _Characters.Count;

        /// <summary>
        /// Add character to characters dictionary.
        /// </summary>
        /// <param name="character">The character object to add.</param>
        /// <returns>True when character is added.</returns>
        public bool Add(Character character)
        {

            return _Characters.TryAdd(character.Id, character);         

        }

        /// <summary>
        /// Get character from characters dictionary by Id.
        /// </summary>
        /// <param name="id">The character Id.</param>
        /// <returns>The character object.</returns>
        public Character Get(long id)
        {

            _Characters.TryGetValue(id, out Character Character);

            return Character;

        }

        /// <summary>
        /// Get character from characters dictionary based on custom query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>The character object.</returns>
        public Character Get(Func<Character, bool> query)
        {

            return _Characters.ToArray().Select(k => k.Value).FirstOrDefault(query);

        }

        /// <summary>
        /// Remove character from characters dictionary.
        /// </summary>
        /// <param name="id">The character Id.</param>
        /// <returns>True when character is removed.</returns>
        public bool Remove(long id)
        {

            return _Characters.TryRemove(id, out Character Character);

        }

    }

}