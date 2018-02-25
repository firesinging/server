using System;
using System.Collections.Generic;

using Libraries.database;
using Libraries.inventory.item;
using Libraries.database.models.character;


namespace Libraries.character
{

    public class AdvisorsAssigned : ModelCharacterAdvisorsAssigned
    {

        public AdvisorsAssigned()
        {

        }

        /// <summary>
        /// Set the advisor to the correct age.
        /// </summary>
        /// <param name="name">The advisor name.</param>
        /// <returns>True when advisor is set.</returns>
        public bool Set(string name)
        {

            if (Database.Advisors.TryGetValue(name, out Advisor Advisor))
            {

                switch (Advisor.Age)
                {

                    case 0:

                        Age1 = name;
                        break;

                    case 1:

                        Age2 = name;
                        break;

                    case 2:

                        Age3 = name;
                        break;

                    case 3:

                        Age4 = name;
                        break;

                    default:

                        throw new ArgumentOutOfRangeException($"AdvisorsAssigned::Set - Could not set advisor { name }");

                }

                return true;

            }

            return false;

        }

        /// <summary>
        /// Assigned advisors to comma seperated string.
        /// </summary>
        /// <returns>Comma seperated string with assigned advisors if any.</returns>
        public string ToCommaString()
        {

            List<string> List = new List<string>() { Age1, Age2, Age3, Age4 };

            List.RemoveAll(item => item == null);

            if(List.Count > 0)
            {

                return string.Join<string>(",", List);

            }

            return null;            

        }        

    }

}