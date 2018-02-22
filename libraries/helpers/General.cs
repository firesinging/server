using System;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;


namespace Libraries.helpers.general
{

    public static class Helper
    {

        private static bool _setConsoleColor;

        /// <summary>
        ///  Convert byte array to string
        /// </summary>
        /// <param name="byteArray">Byte array</param>
        /// <returns>Converted string</returns>
        /// <see cref="https://stackoverflow.com/questions/10940883/c-converting-byte-array-to-string-and-printing-out-to-console"/>
        public static string PrintBytes(byte[] byteArray)
        {

            StringBuilder sb = new StringBuilder("new byte[] { ");

            for (int i = 0; i < byteArray.Length; i++)
            {

                var b = byteArray[i];

                /// Format
                sb.AppendFormat("0x{0:X2}", b);

                if (i < byteArray.Length - 1)
                {

                    sb.Append(", ");

                }                    

            }

            sb.Append(" }");

            return sb.ToString();

        }

        /// <summary>
        /// Check if console color can be set 
        /// </summary>
        public static void CheckCanSetConsoleColor()
        {

            try
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.ResetColor();

                _setConsoleColor = true;

            }
            catch
            {

                _setConsoleColor = false;

            }

        }

        /// <summary>
        /// Set console color 
        /// </summary>
        public static void SetConsoleColor(ConsoleColor color)
        {

            if (!_setConsoleColor)
            {

                return;

            }

            Console.ForegroundColor = color;

        }

        /// <summary>
        /// Copy object properties to another object
        /// </summary>
        /// <seealso cref="https://github.com/herrbpl/csharp-learn-contactdata/blob/edf63153f4d54369f832cf473c80a626f8576f4f/Extenstions/PropertiesCopy.cs"/>
        public static void CopyPropertiesTo<T, TU>(this T source, TU dest)
        {

            CopyPropertiesTo(source, dest, null);

        }

        /// <summary>
        /// Copy object properties to another object with exclude list
        /// </summary>
        /// <seealso cref="https://github.com/herrbpl/csharp-learn-contactdata/blob/edf63153f4d54369f832cf473c80a626f8576f4f/Extenstions/PropertiesCopy.cs"/>
        public static void CopyPropertiesTo<T, TU>(this T source, TU dest, IList<string> exclude)
        {

            List<PropertyInfo> sourceProps = typeof(T).GetProperties().Where(x => x.CanRead).ToList();
            List<PropertyInfo> destProps = typeof(TU).GetProperties().Where(x => x.CanWrite).ToList();

            if (exclude == null)
            {

                exclude = new List<string>();

            }

            foreach (var sourceProp in sourceProps)
            {

                if (!exclude.Contains(sourceProp.Name))
                {

                    if (destProps.Any(x => x.Name == sourceProp.Name))
                    {

                        PropertyInfo p = destProps.First(x => x.Name == sourceProp.Name);

                        if (p.PropertyType.IsAssignableFrom(sourceProp.PropertyType))
                        {

                            p.SetValue(dest, sourceProp.GetValue(source, null), null);

                        }

                    }

                }

            }

        }

    }

}
