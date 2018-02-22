using System;
using System.Collections.Generic;

using Libraries.enums;
using Libraries.database;

using Libraries.helpers.xml;


namespace Libraries.helpers.region
{

    public static class RegionHelper
    {

        private static string _RegionsXML;

        /// <summary>
        ///  Convert unlocked regions list to string
        /// </summary>
        /// <param name="Regions">Unlocked regions list</param>
        /// <returns>Converted string</returns>
        /// <see cref=""/>
        public static string ConvertListToBase64String(List<int> Regions)
        {

            byte[] Array = new byte[Regions.Count * 4];

            //@TODO

            return Convert.ToBase64String(Array);             
            
        }

        /// <summary>
        /// Get all regions XML 
        /// </summary>
        public static string GetRegionsXML()
        {

            if (_RegionsXML == null)
            {

                _RegionsXML = Database.Regions.SerializeObjectToXml();

            }

            return _RegionsXML;

        }

        /// <summary>
        /// Filter quest givers by current civilization id
        /// </summary>
        /// <returns>String list with excluded quest giver civilization tags</returns>
        /// <note>Quest giver civilization tags do not match generic game civilization tags</note>
        public static List<string> FilterQuestgiversbyCivilization(Civilizations civ)
        {

            List<string> Obj = new List<string>() { "C01_", "C02_", "C03_", "C04_", "C05_", "C06_", "C07_" };

            switch (civ)
            {

                case Civilizations.Generic:

                    break;

                case Civilizations.Greek:

                    Obj.Remove("C01_");

                    break;

                case Civilizations.Egypt:

                    Obj.Remove("C02_");

                    break;

                case Civilizations.Celt:

                    Obj.Remove("C03_");

                    break;

                case Civilizations.Persia:

                    Obj.Remove("C04_");

                    break;

                case Civilizations.Babylonian:

                    Obj.Remove("C06_");

                    break;

                case Civilizations.Norse:

                    Obj.Remove("C07_");

                    break;

                default:

                    throw new ArgumentOutOfRangeException($"RegionHelper::FilterQuestgiversbyCivilization - Unknown civilization. Civilization: {civ}");

            }

            return Obj;

        }

    }

}
