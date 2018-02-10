using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

using Libraries.player;

using Libraries.helpers.pathing;
using Libraries.helpers.xml;


namespace Libraries.database.models
{

    /// <summary>
    /// Add all players to players model
    /// </summary>
    /// <seealso cref="https://github.com/VanHelSeenG/M13.13k1/blob/5e4d13961ac37d2d023c7cccae12bdec9d06ec56/M13k1.Contracts/Users/UserRepository.cs"/>
    /// <seealso cref="https://raw.githubusercontent.com/ArchitectureMining/GAEM-DataTransformationTool/774c6aa823852d55a82c3fc9bd6cc681bfde742b/GAEM-DataTransformationTool/DataTransformators/DoxygenToNeo4jImportToolTransformer.cs"/>
    public class ModelPlayers
    {

        protected readonly ConcurrentDictionary<long, Player> _Players;
        protected readonly object _PlayersLock = new object();

        public ModelPlayers()
        {

            _Players = new ConcurrentDictionary<long, Player>(EqualityComparer<long>.Default);

            BlockingCollection<string> fileCollection = CreateBlockingFileCollection(PathingHelper.playerDir);

            int totalAmountOfFiles = fileCollection.Count();
            int taskCount;

            if (totalAmountOfFiles < Environment.ProcessorCount * 2)
            {

                taskCount = totalAmountOfFiles;

            }
            else
            {

                taskCount = Environment.ProcessorCount;

            }

            Task[] taskArray = new Task[taskCount];

            for (int i = 0; i < taskCount; i++)
            {

                taskArray[i] = Task.Factory.StartNew(() =>
                {

                    string fileName;

                    while (!fileCollection.IsCompleted)
                    {

                        if (!fileCollection.TryTake(out fileName))
                        {

                            continue;

                        }

                        Player Player = new Player().DeserializeFromFile(fileName);

                        _Players.TryAdd(Player.Id, Player);

                    }

                });

            }

            Task.WaitAll(taskArray);

        }

        private BlockingCollection<string> CreateBlockingFileCollection(string path)
        {

            string[] allFiles = Directory.GetFiles(path, "*.xml", SearchOption.TopDirectoryOnly);
            BlockingCollection<string> filePaths = new BlockingCollection<string>();

            foreach (string fileName in allFiles)
            {

                filePaths.Add(fileName);

            }

            filePaths.CompleteAdding();

            return filePaths;

        }

    }

}
