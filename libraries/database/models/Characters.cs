using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

using Libraries.character;

using Libraries.helpers.pathing;
using Libraries.helpers.xml;


namespace Libraries.database.models
{

    /// <summary>
    /// Add all characters to characters model
    /// </summary>
    /// <seealso cref="https://github.com/VanHelSeenG/M13.13k1/blob/5e4d13961ac37d2d023c7cccae12bdec9d06ec56/M13k1.Contracts/Users/UserRepository.cs"/>
    /// <seealso cref="https://raw.githubusercontent.com/ArchitectureMining/GAEM-DataTransformationTool/774c6aa823852d55a82c3fc9bd6cc681bfde742b/GAEM-DataTransformationTool/DataTransformators/DoxygenToNeo4jImportToolTransformer.cs"/>
    public class ModelCharacters
    {

        protected readonly ConcurrentDictionary<long, Character> _Characters;
        protected readonly object _CharactersLock = new object();

        public ModelCharacters()
        {

            _Characters = new ConcurrentDictionary<long, Character>(EqualityComparer<long>.Default);

            BlockingCollection<string> fileCollection = CreateBlockingFileCollection($"{PathingHelper.playerDir}characters{Path.DirectorySeparatorChar}");

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

                        Character Character = new Character().DeserializeFromFile(fileName);

                        _Characters.TryAdd(Character.Id, Character);

                    }

                });

            }

            Task.WaitAll(taskArray);

        }

        private BlockingCollection<string> CreateBlockingFileCollection(string path)
        {

            string[] allFiles = Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories);
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
