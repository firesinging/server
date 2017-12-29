using System.IO;
using System.Linq;
using System.Collections.Generic;


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

    }

}
