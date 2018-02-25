using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.logger;
using Libraries.player;
using Libraries.region;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestRefreshQuestGiverSpawns : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            var Request = new PacketBRequestRefreshQuestGiverSpawns(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Player ObjPlayer = s.GetPlayer();

            //@TODO



        }

        /// <summary>
        /// Sends PacketBQuestGiverSpawnUnitPacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRetrievePersistentData or BRequestRefreshQuestGiverSpawns.</param>
        /// <param name="q">The questgiver to spawn.</param>
        /// <note>Untraced package.</note>
        public static void SendResponseGiverSpawn(Session s, Package p, Questgiver q)
        {

            PacketBQuestGiverSpawnUnitPacket ResponseContent = new PacketBQuestGiverSpawnUnitPacket(q.Name, q.Placeunittype, q.ToXml, q.Greetingstringid, q.Greetingsoundset, q.Farewellsoundset, q.Artset);

            Logger.Debug($"{p.Key}::SendResponseGiverSpawn - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BQuestGiverSpawnUnitPacket, 0, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends PacketBQuestGiverDespawnUnitPacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestRefreshQuestGiverSpawns.</param>
        /// <param name="q">The questgiver.</param>
        /// <note>Untraced package.</note>
        public static void SendResponseGiverDespawn(Session s, Package p, Questgiver q)
        {

            PacketBQuestGiverDespawnUnitPacket ResponseContent = new PacketBQuestGiverDespawnUnitPacket(q.Name);

            Logger.Debug($"{p.Key}::SendResponseGiverDespawn - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BQuestGiverDespawnUnitPacket, 0, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
