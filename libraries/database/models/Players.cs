using System.Collections.Concurrent;
using System.Collections.Generic;

using Libraries.database.models;
using Libraries.helpers.pathing;


namespace Libraries.database.models
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="https://github.com/VanHelSeenG/M13.13k1/blob/5e4d13961ac37d2d023c7cccae12bdec9d06ec56/M13k1.Contracts/Users/UserRepository.cs"/>
    public class Players
    {

        private readonly ConcurrentDictionary<long, ModelPlayer> _Players;

        public Players()
        {

            _Players = new ConcurrentDictionary<long, ModelPlayer>();


            /*
             Supersocket
    if (sessions.Length > 0)
-            {
-                var tasks = new Task[sessions.Length];
-
-                for (var i = 0; i < tasks.Length; i++)
-                {
-                    tasks[i] = Task.Factory.StartNew((s) =>
-                    {
-                        var session = s as TAppSession;
-
-                        if (session != null)
-                        {
-                            session.Close(CloseReason.ServerShutdown);
-                        }
-
-                    }, sessions[i].Value);
-                }
-
-                Task.WaitAll(tasks);
-            }

    */
       

        }

    }
}
