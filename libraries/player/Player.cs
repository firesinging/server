using Libraries.exceptions.player;
using Libraries.database.models;
using Libraries.helpers.player;
using Libraries.helpers.pathing;
using Libraries.helpers.xml;


namespace Libraries.player
{

    public class Player
    {

        private long _Id;

        public Player(long Id)
        {

            _Id = Id;

        }

        public Player Login()
        {

            // Check if PlayerName and Password exist -> Return info when does
            // If PlayerName exists but Password doesn't match -> throw new Exception
            // If PlayerName doesn't exist -> Create new player and return info

            return null;

        }

        public bool Logout()
        {

            

            return true;

        }

        /// <summary>
        ///  Create a new player.
        /// </summary>
        /// <param name="playerName">The player name.</param>
        /// <param name="password">The password.</param>
        public bool Create(string playerName, string password)
        {

            //@TODO move to players library

            if (!PlayerHelper.IsValidPlayerName(playerName))
            {

                throw new InvalidPlayerNameException(playerName);

            }

            //@TODO check if playername is not already taken

            if (!PlayerHelper.IsValidPasswordLength(password))
            {

                throw new InvalidPasswordException($"Password length must be between 6 and 24 characters long.");

            }

            ModelPlayer Player = new ModelPlayer();

            Player.Id = PlayerHelper.generatePlayerId();
            Player.Name = playerName;
            Player.Password = password;

            Save(Player);

            return true;

        }

        public bool Save(ModelPlayer Player)
        {

            string SafeName = Player.Name;

            XMLHelper.SerializeObjectToFile(Player, $"{PathingHelper.playerDir}{SafeName}.xml");

            return true;

        }

        public bool Delete()
        {



            return false;

        }



    }

}
