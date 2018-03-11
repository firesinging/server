using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

using Libraries.empire;

using Libraries.helpers.pathing;
using Libraries.helpers.xml;


namespace Libraries.database.models
{

    /// <summary>
    /// Add all empires to empires model
    /// </summary>
    /// <seealso cref="https://github.com/VanHelSeenG/M13.13k1/blob/5e4d13961ac37d2d023c7cccae12bdec9d06ec56/M13k1.Contracts/Users/UserRepository.cs"/>
    /// <seealso cref="https://raw.githubusercontent.com/ArchitectureMining/GAEM-DataTransformationTool/774c6aa823852d55a82c3fc9bd6cc681bfde742b/GAEM-DataTransformationTool/DataTransformators/DoxygenToNeo4jImportToolTransformer.cs"/>
    public class ModelEmpires
    {

        protected readonly ConcurrentDictionary<long, Empire> _Empires;
        protected readonly object _EmpiresLock = new object();

        public ModelEmpires()
        {

            _Empires = new ConcurrentDictionary<long, Empire>(EqualityComparer<long>.Default);

            BlockingCollection<string> fileCollection = CreateBlockingFileCollection($"{PathingHelper.playerDir}empires{Path.DirectorySeparatorChar}");

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

                    while (!fileCollection.IsCompleted)
                    {

                        if (!fileCollection.TryTake(out string fileName))
                        {

                            continue;

                        }

                        Empire Empire = new Empire().DeserializeFromFile(fileName);

                        _Empires.TryAdd(Empire.Id, Empire);

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

                if (!fileName.StartsWith("Default"))
                {

                    filePaths.Add(fileName);

                }

            }

            filePaths.CompleteAdding();

            return filePaths;

        }

    }

}
