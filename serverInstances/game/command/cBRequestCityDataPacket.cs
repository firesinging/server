using System.IO;

using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.helpers.pathing;
using Libraries.packages.game;
using Libraries.enums;


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

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

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

            PacketBResponseCityDataStartPacket ResponseContent = new PacketBResponseCityDataStartPacket(p.HeaderXuid, "Capitals/CAPITAL_C01_02", 1);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

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







        }

        /// <summary>
        /// Sends BResponseCityDataCompletePacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet PacketBRequestCityDataPacket.</param>
        /// <param name="r">Packet PacketBRequestCityDataPacket content.</param>
        private static void _SendCityDataComplete(Session s, Package p, PacketBRequestCityDataPacket r)
        {

            PacketBResponseCityDataCompletePacket ResponseContent = new PacketBResponseCityDataCompletePacket(p.HeaderXuid);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseCityDataCompletePacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
