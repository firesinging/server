using System.IO;
using System.Linq;
using System.Collections.Generic;

using Libraries.helpers.xml;
using Libraries.helpers.pathing;


namespace Libraries.helpers.database
{

    public static class DatabaseHelper
    {

        /// <summary>
        /// Linq exclude directories criteria 
        /// </summary>
        /// <param name="exludedDirList">Directory list to exclude</param>
        /// <param name="filename">The filename</param>
        /// <returns></returns>
        public static bool IsExcluded(List<string> exludedDirList, string filename)
        {

            return exludedDirList.Any(d => Path.GetFileName(Path.GetDirectoryName(filename)).Equals(d));

        }

        /// <summary>
        /// Deserialize game files from database 
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <returns></returns>
        public static T Deserialize<T>(string fileName) where T : new()
        {

            T Instance = new T().DeserializeFromFile($"{PathingHelper.gamedatabaseDir}{fileName}");

            return (T)Instance;

        }

    }

}
