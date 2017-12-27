using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Security.Cryptography;

using Libraries.helpers.random;


namespace Libraries.helpers.player
{

    public static class PlayerHelper
    {

        /// <summary>
        ///  Generates random PlayerId / Xuid 
        /// </summary>
        /// <returns>PlayerId / Xuid</returns>
        public static long generatePlayerId()
        {

            //@TODO check if playerId is not already taken

            RandomEx Random = new RandomEx();

            return Random.NextLong();

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
        ///  Check to see if desired password is valid
        /// </summary>
        /// <param name="password">Desired password</param>
        /// <returns>True if password is valid</returns>
        public static bool IsValidPasswordLength(string password)
        {

            return password.Length >= 6 && password.Length <= 24;

        }

        /// <summary>
        ///  Create password hash
        /// </summary>
        /// <param name="password">Desired password</param>
        /// <returns>Password hash</returns>
        public static string CreateHash(string password)
        {

            string combined = password + ConfigurationManager.AppSettings["PasswordSalt"];

            return _HashString(combined);

        }

        /// <summary>
        ///  Match input password with player password
        /// </summary>
        /// <param name="password">Input password</param>
        /// /// <param name="password">Player hashed password</param>
        /// <returns>True if passwords match</returns>
        public static bool CompareHash(string password, string playerPassword)
        {

            return CreateHash(password) == playerPassword;

        }

        /// <summary>
        ///  Create password hash helper
        /// </summary>
        /// <param name="toHash">Salted password</param>
        /// <returns>Password hash</returns>
        private static string _HashString(string toHash)
        {

            using (SHA512CryptoServiceProvider sha = new SHA512CryptoServiceProvider())
            {

                byte[] data = Encoding.UTF8.GetBytes(toHash);
                byte[] hashed = sha.ComputeHash(data);

                return Convert.ToBase64String(hashed);

            }

        }

    }

}
