using System;
using System.Collections.Generic;

using Libraries.enums;
using Libraries.region;
using Libraries.database;

using Libraries.helpers.xml;


namespace Libraries.helpers.region
{

    public static class RegionHelper
    {

        private static string _RegionsXML;        

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

        /// <summary>
        /// Get quest giver region by quest giver name
        /// </summary>
        /// <param name="name">Quest giver name</param>
        /// <returns>Quest giver region</returns>
        public static int GetQuestGiverRegion(string name)
        {

            if (!string.IsNullOrEmpty(name))
            {

                if (Database.Questgivers.TryGetValue(name, out Questgiver Giver))
                {

                    return Giver.Region;

                }

            }

            return 0;

        }



    }

}
