using System.IO;
using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;
using Libraries.helpers.pathing;


namespace Game.Command
{

    public class BRequestAllianceContestsStatus : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestAllianceContestsStatus Request = new PacketBRequestAllianceContestsStatus(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            //@TODO

            string Xml = File.ReadAllText($"{PathingHelper.tmpDir}BResponseAllianceContestsStatus.xml");

            PacketBResponseAllianceContestsStatus ResponseContent = new PacketBResponseAllianceContestsStatus(Xml);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseAllianceContestsStatus, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
