using System;
using System.IO;

using Libraries.database;
using Libraries.database.models;
using Libraries.logger;
using Libraries.character;

using Libraries.helpers.pathing;
using Libraries.helpers.xml;


namespace Libraries.empire
{

    public class Empire : ModelEmpire
    {

        private readonly object _EmpireLock = new object();

        public Empire()
        {

        }

        /// <summary>
        /// Save the current empire object.
        /// </summary>
        /// <param name="characterSave">Flag to allow character saving when it is not a new player.</param>
        /// <param name="isNew">Flag to allow the creation of a new empire object.</param>
        /// <returns>True when empire object is saved.</returns>
        public bool Save(bool characterSave = false, bool isNew = false)
        {

            Logger.InfoFormat("Empire::Save - Saving empire with Id {0}", Id);

            lock (_EmpireLock)
            {

                try
                {

                    if (isNew)
                    {

                        Database.Empires.Add(this);

                    }
                    else if ((characterSave) && (CurrentCharacterid > 0))
                    {

                        CurrentCharacter.Save();                 

                    }

                    XMLHelper.SerializeObjectToFile(this, $"{PathingHelper.playerDir}empires{Path.DirectorySeparatorChar}{Id}.xml");

                }

                catch (Exception Ex)
                {

                    Logger.ErrorFormat("Empire::Save - Error saving empire with Id {0}. Error: {1}", Id, Ex);

                }

            }

            return File.Exists($"{PathingHelper.playerDir}empires{Path.DirectorySeparatorChar}{Id}.xml");

        }

        /// <summary>
        /// Delete the current empire object.
        /// </summary>
        /// <returns>True when empire object is deleted.</returns>
        public bool Delete()
        {

            lock (_EmpireLock)
            {

                Logger.InfoFormat("Empire::Delete - Delete empire with Id {0}", Id);

                //@TODO

                if (File.Exists($"{PathingHelper.playerDir}empires{Path.DirectorySeparatorChar}{Id}.xml"))
                {

                    File.Delete($"{PathingHelper.playerDir}empires{Path.DirectorySeparatorChar}{Id}.xml");

                }

                if (!Database.Empires.Remove(Id))
                {

                    return false;

                }

            }

            return true;

        }

        /// <summary>
        /// Set the last launched character within empire.
        /// </summary>
        /// <param name="characterId">The character Id.</param>
        public void SetLastLaunchedCharacter(long characterId)
        {

            CurrentCharacterid = characterId;

            Character CurrentCharacter = Database.Characters.Get(characterId);

            Lastlaunched = CurrentCharacter.Name;

            Save();

        }

    }

}