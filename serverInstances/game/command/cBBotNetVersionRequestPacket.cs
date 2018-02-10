using SuperSocket.SocketBase.Command;

using Libraries.packages.game;
using Libraries.enums;
using Libraries.logger;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BBotNetVersionRequestPacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBBotNetVersionRequestPacket Request = new PacketBBotNetVersionRequestPacket(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            PacketBBotNetVersionResponsePacket ResponseContent = new PacketBBotNetVersionResponsePacket(1);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BBotNetVersionResponsePacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);            

        }

    }

}
