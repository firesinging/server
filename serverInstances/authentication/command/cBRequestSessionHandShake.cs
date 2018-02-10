using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.player;
using Libraries.database;
using Libraries.packages.custom;
using Libraries.logger;

using Libraries.helpers.package;
using Libraries.helpers.player;


namespace Authentication.Command
{

    public class BRequestSessionHandShake : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// Creates player if not exists
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestSessionHandShake Request = new PacketBRequestSessionHandShake(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            if (!s.IsAuthenticated)
            {

                if (!PlayerHelper.PlayerNameExists(Request.PlayerName))
                {
                        
                    if ((PlayerHelper.IsValidPlayerName(Request.PlayerName)) && (PlayerHelper.IsValidPasswordLength(Request.Password)))
                    {

                        Logger.Info(p.Key + "::ExecuteCommand - Create new player " + Request.PlayerName + " from IP " + s.RemoteEndPoint.Address.ToString());

                        Player New = new Player();

                        New.Name = Request.PlayerName;
                        New.Password = PlayerHelper.CreateHash(Request.Password);

                        New.Save(false, false, true);

                    }                           

                }
                    
                Player Player = Database.Players.Get(Request.PlayerName, Request.Password);

                if (Player != null)
                {

                    s.SetPlayer(Player);

                }

            } 

            PacketBResponseSessionHandShake ResponseContent = new PacketBResponseSessionHandShake(1);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseSessionHandShake, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
