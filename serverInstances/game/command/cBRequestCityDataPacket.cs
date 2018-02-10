using SuperSocket.SocketBase.Command;

using Libraries.packages.game;
using Libraries.enums;
using Libraries.player;
using Libraries.logger;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestCityDataPacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestCityDataPacket Request = new PacketBRequestCityDataPacket(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            _SendResponseCityDataStart(s, p, Request);
            _SendResponseGetContainerNumSlots(s, p, Request);


            
            _SendCityDataComplete(s, p, Request);

           



        }

        /// <summary>
        /// Sends CityDataStartPacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestCityData.</param>
        /// <param name="r">Packet BRequestCityData content.</param>
        private static void _SendResponseCityDataStart(Session s, Package p, PacketBRequestCityDataPacket r)
        {

            Player Player = s.GetPlayer();

            PacketBResponseCityDataStartPacket ResponseContent = new PacketBResponseCityDataStartPacket(Player.Id, Player.Empire.CurrentCharacter.Capscenario, 1);

            Logger.Debug(p.Key + "::_SendResponseCityDataStart - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseCityDataStartPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends GetContainerNumSlots.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData.</param>
        /// <param name="r">Packet BRequestRetrievePersistentData content.</param>
        private static void _SendResponseGetContainerNumSlots(Session s, Package p, PacketBRequestCityDataPacket r)
        {

            //@TODO

            string ResponseContent = string.Empty;

            Logger.Debug(p.Key + "::_SendResponseGetContainerNumSlots - Execute command: " + ResponseContent);







        }

        /// <summary>
        /// Sends BResponseCityDataCompletePacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet PacketBRequestCityDataPacket.</param>
        /// <param name="r">Packet PacketBRequestCityDataPacket content.</param>
        private static void _SendCityDataComplete(Session s, Package p, PacketBRequestCityDataPacket r)
        {

            Player Player = s.GetPlayer();

            PacketBResponseCityDataCompletePacket ResponseContent = new PacketBResponseCityDataCompletePacket(Player.Id);

            Logger.Debug(p.Key + "::_SendCityDataComplete - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseCityDataCompletePacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
