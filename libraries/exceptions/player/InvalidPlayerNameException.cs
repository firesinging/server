using System;


namespace Libraries.exceptions.player
{

    public class InvalidPlayerNameException : Exception
    {

        public string PlayerName { get; protected set; }

        public InvalidPlayerNameException(string playerName) : base(string.Format("Invalid player name '{0}'.", playerName))
        {

            PlayerName = playerName;

        }

    }

}
