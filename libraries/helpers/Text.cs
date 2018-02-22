using System;


namespace Libraries.helpers.text
{

    public static class TextHelper
    {

        /// <summary>
        /// Get text before split string based on char delimiter 
        /// </summary>
        /// <param name="source">The string.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="appendDelimiter">Flag to append delimiter to return string.</param>
        /// <returns>Text before split string</returns>
        public static string SubstringFirst(this string source, char delimiter, bool appendDelimiter = false)
        {

            int i = source.IndexOf(delimiter);

            return (i == -1) ? source : (appendDelimiter) ? $"{ source.Substring(0, i)}{delimiter}" : source.Substring(0, i);

        }

        /// <summary>
        /// Get text before split string based on string delimiter 
        /// </summary>
        /// <param name="source">The string.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="appendDelimiter">Flag to append delimiter to return string.</param>
        /// <returns>Text before split string</returns>
        public static string SubstringFirst(this string source, string delimiter, bool appendDelimiter = false)
        {

            int i = source.IndexOf(delimiter);

            return (i == -1) ? source : (appendDelimiter) ? $"{ source.Substring(0, i)}{delimiter}" : source.Substring(0, i);

        }
        
    }

}

