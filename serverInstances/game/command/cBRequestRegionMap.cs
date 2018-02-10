using SuperSocket.SocketBase.Command;

using Libraries.database;
using Libraries.packages.game;
using Libraries.enums;
using Libraries.player;
using Libraries.logger;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestRegionMap : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestRegionMap Request = new PacketBRequestRegionMap(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            Player Player = s.GetPlayer();

            Player.Empire.CurrentCharacter.Currentregion = Request.RegionId;

            Player.Save();

            PacketBResponseRequestRegionMap ResponseContent = new PacketBResponseRequestRegionMap(1, Database.Regions[Request.RegionId].Mapname);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseRequestRegionMap, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
