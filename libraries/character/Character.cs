using System;
using System.IO;

using Libraries.database;
using Libraries.enums;
using Libraries.empire;
using Libraries.logger;
using Libraries.database.models;
using Libraries.database.models.empire;

using Libraries.helpers.pathing;
using Libraries.helpers.xml;


namespace Libraries.character
{

    public class Character : ModelCharacter
    {

        private readonly object _SaveCharacterLock = new object();

        public Character()
        {

        }

        /// <summary>
        /// Save the current character object.
        /// </summary>
        /// <param name="isNew">Flag to allow the creation of a new character object.</param>
        /// <returns>True when character object is saved.</returns>
        public bool Save(bool isNew = false)
        {

            lock (_SaveCharacterLock)
            {

                try
                {

                    if (isNew)
                    {

                        Database.Characters.Add(this);

                        Empire ObjEmpire = Database.Empires.Get(PlayerId);

                        ModelEmpireCharacterlistCharacterData Item = new ModelEmpireCharacterlistCharacterData { CharacterId = Id };

                        ObjEmpire.Lastlaunched = Name;

                        Item.CivId = CivId;
                        Item.Level = Level;
                        Item.Name = Name;
                        
                        ObjEmpire.Characterlist.Items.Add(Id, Item);

                        ObjEmpire.Save();

                    }

                    Logger.Info($"Character::Save - Saving character {Name} with Id {Id}");

                    XMLHelper.SerializeObjectToFile(this, $"{PathingHelper.playerDir}characters{Path.DirectorySeparatorChar}civ{Enum.GetName(typeof(Civilizations), CivId)}{Path.DirectorySeparatorChar}{Id}.xml");

                }

                catch (Exception Ex)
                {

                    Logger.Error($"Character::Save - Error saving character {Name} with Id {Id}. Error: {Ex}");

                }

            }

            return File.Exists($"{PathingHelper.playerDir}characters{Path.DirectorySeparatorChar}civ{Enum.GetName(typeof(Civilizations), CivId)}{Path.DirectorySeparatorChar}{Id}.xml");

        }

        /// <summary>
        /// Delete the current character object.
        /// </summary>
        /// <returns>True when character object is deleted.</returns>
        public bool Delete()
        {

            //@TODO

            return true;

        }        

    }

}