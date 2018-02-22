using System;
using System.Linq;

using Libraries.database.models;


namespace Libraries.empire
{
    /// <summary>
    /// Empires library to maintain empires dictionary.
    /// </summary>
    public class Empires : ModelEmpires
    {

        public Empires()
        {

        }

        /// <summary>
        /// Total number of empires.
        /// </summary>
        public int Total => _Empires.Count;

        /// <summary>
        /// Add empire to empires dictionary.
        /// </summary>
        /// <param name="empire">The empire object to add.</param>
        /// <returns>True when empire is added.</returns>
        public bool Add(Empire empire)
        {

            return _Empires.TryAdd(empire.Id, empire);         

        }

        /// <summary>
        /// Get empire from empires dictionary by Id.
        /// </summary>
        /// <param name="id">The empire Id.</param>
        /// <returns>The empire object.</returns>
        public Empire Get(long id)
        {

            _Empires.TryGetValue(id, out Empire ObjEmpire);

            return ObjEmpire;

        }

        /// <summary>
        /// Get empire from empires dictionary based on custom query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>The empire object.</returns>
        public Empire Get(Func<Empire, bool> query)
        {

            return _Empires.ToArray().Select(k => k.Value).FirstOrDefault(query);

        }

        /// <summary>
        /// Remove empire from empires dictionary.
        /// </summary>
        /// <param name="id">The empire Id.</param>
        /// <returns>True when empire is removed.</returns>
        public bool Remove(long id)
        {

            return _Empires.TryRemove(id, out Empire ObjEmpire);

        }

    }

}