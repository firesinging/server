using System;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

using Libraries.database;

using Libraries.helpers.random;


namespace Libraries.helpers.player
{

    public static class PlayerHelper
    {

        /// <summary>
        ///  Generates random PlayerId / Xuid 
        /// </summary>
        /// <returns>PlayerId / Xuid</returns>
        public static long generatePlayerId(int counter = 0)
        {

            long Result = StaticRandom.NextLong();

            if (Database.Players.Get(Result) != null)
            {

                if (counter < 100)
                {

                    counter++;

                    generatePlayerId(counter);

                }
                else
                {

                    throw new ArgumentException($"PlayerHelper::generatePlayerId - Can not generate random player Id after {counter} tries");

                }

            }

            return Result;

        }

        /// <summary>
        ///  Check to see if desired player name is valid
        /// </summary>
        /// <param name="playerName">Desired player name</param>
        /// <returns>True if player name is valid</returns>
        public static bool IsValidPlayerName(string playerName)
        {

            if (string.IsNullOrEmpty(playerName) || playerName.Length < 6 || playerName.Length > 16)
            {

                return false;

            }

            Regex regex = new Regex(@"[a-zA-Z0-9_]+");

            if (!string.IsNullOrEmpty(playerName) && regex.IsMatch(playerName))
            {

                return true;

            }

            return false;

        }

        /// <summary>
        ///  Check to see if desired player name already exists
        /// </summary>
        /// <param name="playerName">Desired player name</param>
        /// <returns>True if player name already exists</returns>
        public static bool PlayerNameExists(string playerName)
        {

            if(Database.Players.Get(key => string.Equals(key.Name, playerName, StringComparison.CurrentCultureIgnoreCase)) != null)
            {

                return true;

            }

            return false;

        }

        /// <summary>
        ///  Check to see if desired password is valid
        /// </summary>
        /// <param name="password">Desired password</param>
        /// <returns>True if password is valid</returns>
        public static bool IsValidPasswordLength(string password)
        {

            return password.Length >= 6 && password.Length <= 24;

        }

        /// <summary>
        ///  Match input password with player password
        /// </summary>
        /// <param name="password">Input password</param>
        /// <param name="playerPassword">Player hashed password</param>
        /// <returns>True if passwords match</returns>
        public static bool CompareHash(string password, string playerPassword)
        {

            return CreateHash(password) == playerPassword;

        }

        /// <summary>
        ///  Create password hash
        /// </summary>
        /// <param name="password">Desired password</param>
        /// <returns>Password hash</returns>
        public static string CreateHash(string password)
        {

            byte[] buffer = Encoding.Default.GetBytes(password + ConfigurationManager.AppSettings["PasswordSalt"]);

            SHA512CryptoServiceProvider Provider = new SHA512CryptoServiceProvider();

            string hash = BitConverter.ToString(Provider.ComputeHash(buffer)).Replace("-", "");

            return hash;

        }

    }

}
