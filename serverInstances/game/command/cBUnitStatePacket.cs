using SuperSocket.SocketBase.Command;

using Libraries.player;
using Libraries.logger;
using Libraries.packages.game;
using Libraries.database.models.character;

using Libraries.helpers.package;
using Libraries.helpers.xml;


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

            Player ObjPlayer = s.GetPlayer();

            ModelCharacterUnitStateClient UnitStateClient = new ModelCharacterUnitStateClient().DeserializeFromXml(Request.UnitClientState);
            ModelCharacterUnitStateServer UnitStateServer = new ModelCharacterUnitStateServer().DeserializeFromXml(Request.UnitServerState);

            if(ObjPlayer.Empire.CurrentCharacter.Unitstates.Items.TryGetValue(UnitStateClient.Unitname, out ModelCharacterUnitState CharacterUnitState))
            {

                if(UnitStateServer.Alive != 1)
                {

                    ObjPlayer.Empire.CurrentCharacter.Unitstates.Items.Remove(UnitStateClient.Unitname);

                    Logger.Debug($"{p.Key}::ExecuteCommand - Removed protounit: {UnitStateClient.Protounit}. Id: {UnitStateClient.Unitname}");

                } else
                {

                    CharacterUnitState.Client = UnitStateClient;
                    CharacterUnitState.Server = UnitStateServer;

                    Logger.Debug($"{p.Key}::ExecuteCommand - Updated protounit: {UnitStateClient.Protounit}. Id: {UnitStateClient.Unitname}");

                }              

            } else
            {

                ModelCharacterUnitState UnitState = new ModelCharacterUnitState { Unitname = UnitStateClient.Unitname, Protounit = UnitStateClient.Protounit, Client = UnitStateClient, Server = UnitStateServer };

                ObjPlayer.Empire.CurrentCharacter.Unitstates.Items.Add(UnitState.Unitname, UnitState);

                Logger.Debug($"{p.Key}::ExecuteCommand - Created protounit: {UnitStateClient.Protounit}. Id: {UnitStateClient.Unitname}");

            }

        }

    }

}
