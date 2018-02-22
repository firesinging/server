using Libraries.database;


namespace Libraries.helpers.server
{

    public class ServerHelper
    {
         
        public static bool OnServerStart()
        {
            
            if (!Database.Instance)
            {

                return false;

            }

            return true;

        }

    }

}
