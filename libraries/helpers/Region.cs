using System;
using System.Collections.Generic;

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

    }

}
