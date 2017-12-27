using System;
using System.IO;

namespace Libraries.helpers.pathing
{

    public static class PathingHelper
    {

        public static readonly string baseDir = $"{AppDomain.CurrentDomain.BaseDirectory}";

        public static readonly string gamedatabaseDir = $"{baseDir}{Path.DirectorySeparatorChar}database{Path.DirectorySeparatorChar}game{Path.DirectorySeparatorChar}";
        public static readonly string playerDir = $"{baseDir}{Path.DirectorySeparatorChar}database{Path.DirectorySeparatorChar}players{Path.DirectorySeparatorChar}";

        // Temp directory for fixed package content
        public static readonly string tmpDir = $"{baseDir}{Path.DirectorySeparatorChar}database{Path.DirectorySeparatorChar}tmp{Path.DirectorySeparatorChar}";

    }

}
