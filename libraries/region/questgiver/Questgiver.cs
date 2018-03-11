using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models;


namespace Libraries.region
{

    [XmlRoot(ElementName = "questgiver")]
    public class Questgiver : ModelQuestgiver
    {

        public Questgiver()
        {

        }

        /// <summary>
        /// Check if questgiver is available by default.
        /// </summary>
        /// <returns>True if questgiver is available by default.</returns>
        public bool IsAvailableToAll()
        {

            if (Status.ToLower() == "available")
            {

                return true;

            }

            return false;

        }

    }

}
