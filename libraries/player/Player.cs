using System;
using System.IO;

using Libraries.database;
using Libraries.database.models;
using Libraries.empire;
using Libraries.logger;

using Libraries.helpers.pathing;
using Libraries.helpers.xml;
using Libraries.helpers.player;


namespace Libraries.player
{

    public class Player : ModelPlayer
    {

        private readonly object _PlayerLock = new object();

        public Player()
        {                       

        }

        /// <summary>
        /// Save the current player object.
        /// </summary>
        /// <param name="empireSave">Flag to allow empire saving when it is not a new player.</param>
        /// <param name="characterSave">Flag to allow character saving when it is not a new player.</param>
        /// <param name="isNew">Flag to allow the creation of a new player object.</param>
        /// <returns>True when player object is saved.</returns>
        public bool Save(bool empireSave = true, bool characterSave = true, bool isNew = false)
        {

            lock (_PlayerLock)
            {

                try
                {

                    if (isNew)
                    {

                        Empire newEmpire = new Empire().DeserializeFromFile($"{PathingHelper.playerDir}empires{Path.DirectorySeparatorChar}Default.xml");

                        Id = newEmpire.Id = PlayerHelper.generatePlayerId();

                        newEmpire.Save(true, true);

                        Database.Players.Add(this);                       
                        
                    } else if (empireSave)
                    {

                        Empire.Save(characterSave);

                    }

                    Logger.InfoFormat("Player::Save - Saving player {0} with Id {1}", Name, Id);

                    XMLHelper.SerializeObjectToFile(this, $"{PathingHelper.playerDir}{Id}.xml");

                }

                catch (Exception Ex)
                {

                    Logger.ErrorFormat("Player::Save - Error saving player {0} with Id {1}. Error: {2}", Name, Id, Ex);

                }

            }           

            return File.Exists($"{PathingHelper.playerDir}{Id}.xml");

        }

        /// <summary>
        /// Logout the current player object.
        /// </summary>
        /// <returns>True when player object is logged out.</returns>
        public bool Logout()
        {

            //@TODO

            return true;

        }

        /// <summary>
        /// Delete the current player object.
        /// </summary>
        /// <returns>True when player object is deleted.</returns>
        public bool Delete()
        {

            Logger.InfoFormat("Player::Delete - Delete player {0} with Id {1}", Name, Id);

            //@TODO

            lock (_PlayerLock)
            {

                Empire Empire = Database.Empires.Get(Id);

                if (!Empire.Delete())
                {

                    return false;

                }

                if (File.Exists($"{PathingHelper.playerDir}{Id}.xml"))
                {

                    File.Delete($"{PathingHelper.playerDir}{Id}.xml");

                }

                if (!Database.Players.Remove(Id))
                {

                    return false;

                }

            }

            return true;

        }



    }

}
