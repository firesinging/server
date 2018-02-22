using System;
using System.IO;


namespace Libraries.helpers.pathing
{

    public static class PathingHelper
    {

        public static readonly string baseDir = $"{AppDomain.CurrentDomain.BaseDirectory}";

        public static readonly string gamedatabaseDir = $"{baseDir}database{Path.DirectorySeparatorChar}game{Path.DirectorySeparatorChar}";
        public static readonly string playerDir = $"{baseDir}database{Path.DirectorySeparatorChar}players{Path.DirectorySeparatorChar}";

        // Temp directory for fixed package content
        public static readonly string tmpDir = $"{baseDir}database{Path.DirectorySeparatorChar}tmp{Path.DirectorySeparatorChar}";

    }

}
