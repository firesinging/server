using System.Collections.Generic;
using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.player;
using Libraries.logger;
using Libraries.packages.game;
using Libraries.database.models.character;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestCityDataPacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestCityDataPacket Request = new PacketBRequestCityDataPacket(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            SendResponseCityDataStart(s, p);
            SendResponseUnitClientState(s, p);

            BRequestInventoryDataPacket.InitInventory(s, p);   
            
            SendCityDataComplete(s, p);

        }

        /// <summary>
        /// Sends CityDataStartPacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestCityData.</param>
        public static void SendResponseCityDataStart(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            PacketBResponseCityDataStartPacket ResponseContent = new PacketBResponseCityDataStartPacket(ObjPlayer.Id, ObjPlayer.Empire.CurrentCharacter.Capscenario, 1);

            Logger.Debug($"{p.Key}::SendResponseCityDataStart - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseCityDataStartPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends BUnitClientStatePacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestCityData.</param>
        public static void SendResponseUnitClientState(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            if (ObjPlayer.Empire.CurrentCharacter.Unitstates.Items.Count > 0)
            {

                foreach (KeyValuePair<string, ModelCharacterUnitState> Item in ObjPlayer.Empire.CurrentCharacter.Unitstates.Items)
                {

                    PacketBUnitClientStatePacket ResponseContent = new PacketBUnitClientStatePacket(Item.Value.Client.ToXml, 0);

                    Logger.Debug($"{p.Key}::SendResponseUnitClientState - Execute command: {ResponseContent}");

                    byte[] Response = ResponseContent.ToByteArray();

                    Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BUnitClientStatePacket, 0, Response);

                    byte[] ToSend = Package.ToByteArray();

                    s.Send(ToSend, 0, ToSend.Length);
                    
                }

            }

        }

        /// <summary>
        /// Sends BResponseCityDataCompletePacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet PacketBRequestCityDataPacket.</param>
        public static void SendCityDataComplete(Session s, Package p)
        {

            Player ObjPlayer = s.GetPlayer();

            PacketBResponseCityDataCompletePacket ResponseContent = new PacketBResponseCityDataCompletePacket(ObjPlayer.Id);

            Logger.Debug($"{p.Key}::SendCityDataComplete - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseCityDataCompletePacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
