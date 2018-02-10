using System;


namespace Libraries.exceptions.player
{

    public class PlayerNameExistsException : Exception
    {

        public string PlayerName { get; protected set; }

        public PlayerNameExistsException(string playerName) : base(string.Format("Player name '{0}' already exists.", playerName))
        {

            PlayerName = playerName;

        }

    }

}
