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
        /// <param name="player">The player object to add.</param>
        /// <returns>True when player is added.</returns>
        public bool Add(Player player)
        {

            return _Players.TryAdd(player.Id, player);

        }

        /// <summary>
        /// Get player from players dictionary by Id.
        /// </summary>
        /// <param name="id">The player Id.</param>
        /// <returns>The player object.</returns>
        public Player Get(long id)
        {

            _Players.TryGetValue(id, out Player Player);

            return Player;

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

            Player Player = Get(key => string.Equals(key.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if(Player != null && PlayerHelper.CompareHash(password, Player.Password))
            {

                return Player;

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

            return _Players.TryRemove(id, out Player Player);

        }

    }

}