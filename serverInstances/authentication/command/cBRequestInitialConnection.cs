using System.Configuration;
using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.logger;
using Libraries.packages.authentication;

using Libraries.helpers.package;


namespace Authentication.command
{

    public class BRequestInitialConnection : CommandBase<Session, Package>
    {

        public const short GamePort = 1510;

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestInitialConnection Request = new PacketBRequestInitialConnection(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            ConnectionResponseTypes ResponseResult;

            if (ConfigurationManager.AppSettings["MaintenanceMode"] == "1")
            {

                ResponseResult = ConnectionResponseTypes.Maintenance;

            }
            else if (!s.IsAuthenticated)
            {

                ResponseResult = ConnectionResponseTypes.TimeOut1;

            }
            else if (s.GetPlayer().Ban)
            {

                ResponseResult = ConnectionResponseTypes.Banned;

            } else
            {

                ResponseResult = ConnectionResponseTypes.Allowed;

            }

            PacketBResponseInitialConnection ResponseContent = new PacketBResponseInitialConnection(Request.Xuid, 0, ResponseResult, string.Empty, string.Empty, GamePort, string.Empty, string.Empty);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseInitialConnection, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
