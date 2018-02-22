using Libraries.database.models.player;


namespace Libraries.player
{

    public class PlayerMails : ModelPlayerMailmessages
    {

        public PlayerMails()
        {

        }

        /// <summary>
        /// Delete mail item by Id.
        /// </summary>
        /// <param name="id">The mail item Id.</param>
        /// <returns>True if mail is deleted.</returns>
        public bool Delete(long id)
        {

            return Items.Remove(id);

        }

    }

}
