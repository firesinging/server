using SuperSocket.WebSocket.SubProtocol;

using Libraries.enums;
using Libraries.player;
using Libraries.database;
using Libraries.logger;
using Libraries.manager.models;


namespace Manager.Command
{
    
    /// <summary>
    /// Login command, which used for login in
    /// </summary>
    public class LOGIN : JsonSubCommand<Session, LoginInfo>
    {
        
        /// <summary>
        /// Executes the json command.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="commandInfo">The command info.</param>
        protected override void ExecuteJsonCommand(Session s, LoginInfo p)
        {

            Logger.Debug($"LOGIN::ExecuteCommand");

            Player ObjPlayer = Database.Players.Get(p.PlayerName, p.Password);

            if ((ObjPlayer != null) && (ObjPlayer.ACL.Items.Contains(PlayerACL.ConnectManagerServer)))
            {

                s.Player = ObjPlayer;

                SendJsonMessage(s, new LoginResult { Result = true, NodeStatus = s.AppServer.CurrentNodeStatus, ServerMetadataSource = s.AppServer.ServerStatusMetadataSource });

            } else
            {

                SendJsonMessage(s, new LoginResult { Result = false, Message = "Invalid credential!" });

            }      

        }

    }

}
