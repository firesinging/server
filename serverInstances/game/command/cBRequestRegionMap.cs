using SuperSocket.SocketBase.Command;

using Libraries.database;

using Libraries.helpers.package;
using Libraries.packages.game;
using Libraries.enums;


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

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            string RegionFile = Database.Regions[Request.RegionId].Mapname;      

            PacketBResponseRequestRegionMap ResponseContent = new PacketBResponseRequestRegionMap(1, RegionFile);

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Command response: {ResponseContent}");

            }
                
            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseRequestRegionMap, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
