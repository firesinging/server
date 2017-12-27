using System;


namespace Libraries.exceptions.player
{

    public class InvalidPasswordException : ArgumentException
    {

        public InvalidPasswordException(string message) : base(message)
        {
            
        }

    }

}
