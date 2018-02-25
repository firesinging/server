using SuperSocket.SocketBase.Command;

using Libraries.database;
using Libraries.logger;
using Libraries.vendor;
using Libraries.packages.game;
using Libraries.database.models.inventory;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestPopulateVendor : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestPopulateVendor Request = new PacketBRequestPopulateVendor(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            ModelInventoryInfo Info = new ModelInventoryInfo() { Id = Request.Container, Maxcapacity = 0 };

            if (Database.Vendors.TryGetValue(Request.Vendor, out Vendor v))
            {

                BRequestInventoryDataPacket.SendResponseGetContainerNumSlots(s, p, Info, 0);
                BRequestInventoryDataPacket.SendResponseStringListInventory(s, p, v.ToXml(Request.Container));

            }            

            //@TODO log error if not exists
        }

    }

}
