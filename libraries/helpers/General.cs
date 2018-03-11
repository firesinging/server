using System;
using System.IO;
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
        public static string PrintBytes(byte[] byteArray)
        {

            StringBuilder sb = new StringBuilder("new byte[] { ");

            for (int i = 0; i < byteArray.Length; i++)
            {

                var b = byteArray[i];

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

        /// <summary>
        ///  Convert list to bytes
        /// </summary>
        /// <param name="lst">The list.</param>
        /// <returns>Converted bytes</returns>
        public static byte[] ConvertListToBytes(List<int> lst)
        {

            Dictionary<int, List<int>> Collection = new Dictionary<int, List<int>>();

            foreach (int Item in lst)
            {

                if (!Collection.ContainsKey(Item >> 3))
                {

                    Collection.Add(Item >> 3, new List<int>());

                }

                Collection[Item >> 3].Add(1 << (Item & 7));

            }

            byte[] ConvertArray = new byte[Collection.Count];

            foreach (KeyValuePair<int, List<int>> Item in Collection)
            {

                ConvertArray[Item.Key] = Convert.ToByte(Item.Value.Sum());

            }

            using (MemoryStream Stream = new MemoryStream())
            {

                using (BinaryWriter Writer = new BinaryWriter(Stream))
                {

                    for (int i = 0; i < ConvertArray.Length; i++)
                    {

                        Writer.Write(ConvertArray[i]);

                    }

                    return Stream.ToArray();

                }

            }

        }

    }

}
