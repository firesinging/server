using System;
using System.Linq;

using Libraries.database.models;

using Libraries.helpers.player;


namespace Libraries.player
{

    /// <summary>
    /// Players library to maintain players dictionary.
    /// </summary>
    public class Players : ModelPlayers
    {

        public Players()
        {

        }

        /// <summary>
        /// Total number of players.
        /// </summary>
        public int Total => _Players.Count;

        /// <summary>
        /// Add player to players dictionary.
        /// </summary>
        /// <param name="objPlayer">The player object to add.</param>
        /// <returns>True when player is added.</returns>
        public bool Add(Player objPlayer)
        {

            return _Players.TryAdd(objPlayer.Id, objPlayer);

        }

        /// <summary>
        /// Get player from players dictionary by Id.
        /// </summary>
        /// <param name="id">The player Id.</param>
        /// <returns>The player object.</returns>
        public Player Get(long id)
        {

            _Players.TryGetValue(id, out Player ObjPlayer);

            return ObjPlayer;

        }

        /// <summary>
        /// Get player from players dictionary based on custom query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>The player object.</returns>
        public Player Get(Func<Player, bool> query)
        {

            return _Players.ToArray().Select(k => k.Value).FirstOrDefault(query);

        }

        /// <summary>
        /// Authenticate player against players dictionary.
        /// </summary>
        /// <param name="name">The player name.</param>
        /// <param name="password">The player password.</param>
        /// <returns>The player object.</returns>
        public Player Get(string name, string password)
        {

            Player ObjPlayer = Get(key => string.Equals(key.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if((ObjPlayer != null) && (PlayerHelper.CompareHash(password, ObjPlayer.Password)))
            {

                return ObjPlayer;

            } else
            {

                return null;

            }

        }

        /// <summary>
        /// Remove player from players dictionary.
        /// </summary>
        /// <param name="id">The player Id.</param>
        /// <returns>True when player is removed.</returns>
        public bool Remove(long id)
        {

            return _Players.TryRemove(id, out Player ObjPlayer);

        }

    }

}