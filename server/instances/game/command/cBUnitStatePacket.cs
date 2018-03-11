using SuperSocket.SocketBase.Command;

using Libraries.logger;
using Libraries.inventory;
using Libraries.character;
using Libraries.packages.game;
using Libraries.database.models.character;

using Libraries.helpers.package;
using Libraries.helpers.xml;
using Libraries.helpers.inventory;


namespace Game.Command
{

    public class BUnitStatePacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBUnitStatePacket Request = new PacketBUnitStatePacket(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Character ObjCharacter = s.Player.Empire.CurrentCharacter;

            ModelCharacterUnitStateClient UnitStateClient = new ModelCharacterUnitStateClient().DeserializeFromXml(Request.UnitClientState);
            ModelCharacterUnitStateServer UnitStateServer = new ModelCharacterUnitStateServer().DeserializeFromXml(Request.UnitServerState);

            if (ObjCharacter.Unitstates.Items.TryGetValue(UnitStateClient.Unitname, out ModelCharacterUnitState CharacterUnitState))
            {

                if (UnitStateServer.Alive != 1)
                {

                    ObjCharacter.Unitstates.Items.Remove(UnitStateClient.Unitname);

                    Logger.Debug($"{p.Key}::ExecuteCommand - Removed protounit: {UnitStateClient.Protounit}. Id: {UnitStateClient.Unitname}");

                }
                else
                {

                    CharacterUnitState.Client = UnitStateClient;
                    CharacterUnitState.Server = UnitStateServer;

                    Logger.Debug($"{p.Key}::ExecuteCommand - Updated protounit: {UnitStateClient.Protounit}. Id: {UnitStateClient.Unitname}");

                }

            }
            else
            {

                ModelCharacterUnitState UnitState = new ModelCharacterUnitState { Unitname = UnitStateClient.Unitname, Protounit = UnitStateClient.Protounit, Client = UnitStateClient, Server = UnitStateServer };

                ObjCharacter.Unitstates.Items.Add(UnitState.Unitname, UnitState);

                Logger.Debug($"{p.Key}::ExecuteCommand - Created protounit: {UnitStateClient.Protounit}. Id: {UnitStateClient.Unitname}");

            }

            if ((!string.IsNullOrEmpty(UnitStateClient.Unitname)) && (InventoryHelper.IsNewWarehouse(UnitStateClient.Protounit, UnitStateClient.Unitname, ObjCharacter.Inventories)))
            {

                Inventory ObjNewInventory = new Inventory();

                ObjNewInventory.SetInfo(UnitStateClient.Unitname, InventoryHelper.MaxcapacityForWarehouse(UnitStateClient.Protounit));
                ObjNewInventory.SetInventory(UnitStateClient.Unitname);

                ObjCharacter.Inventories.Add(ObjNewInventory);               

                Inventory ObjInventory = ObjCharacter.Inventories.Get(UnitStateClient.Unitname);

                BRequestInventoryDataPacket.SendResponseGetContainerNumSlots(s, p, ObjInventory.Info, 1);
                BRequestInventoryDataPacket.SendResponseStringListInventory(s, p, ObjInventory.Inventory.ToXml);

                Logger.Debug($"{p.Key}::ExecuteCommand - Created inventory for character id {ObjCharacter.Id}. Protounit: {UnitStateClient.Protounit} with id {UnitStateClient.Unitname}");

            }

        }

    }

}
