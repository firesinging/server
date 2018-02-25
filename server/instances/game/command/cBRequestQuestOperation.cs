using System;
using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.database;
using Libraries.logger;
using Libraries.player;
using Libraries.quest;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestQuestOperation : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestQuestOperation Request = new PacketBRequestQuestOperation(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Player ObjPlayer = s.GetPlayer();
            Quest ObjQuest = Database.Quests[Request.Id];

            switch (Request.Operation)
            {

                case QuestOperationTypes.QuestStartDefault:
                {

                    PacketBResponseLaunchQuestMapPacket ResponseContentMap = new PacketBResponseLaunchQuestMapPacket(ObjQuest.Id, Convert.ToByte(ObjQuest.IsRandomMap()), ObjQuest.Randommap.Map, ObjQuest.Randommap.Numplayers, 0, -1, ObjQuest.Randommap.Mapvariables.ToXml, ObjQuest.GetNuggets(ObjPlayer.Empire.CurrentCharacter.Level), ObjQuest.Level, ObjQuest.Questbasescale);

                    SendResponseLaunchQuestMapPacket(s, p, ResponseContentMap);

                    PacketBResponseQuestOperation ResponseContentOp = new PacketBResponseQuestOperation(ObjQuest.Id, QuestOperationTypes.QuestStartDefault, 0, 0, 0);

                    SendResponseQuestOperation(s, p, ResponseContentOp);

                    break;

                }

                default:

                    throw new ArgumentOutOfRangeException($"{p.Key}::ExecuteCommand - Unknown quest operation. Operation: {Request.Operation}");

            }            

        }

        /// <summary>
        /// Sends BResponseQuestOperation.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestQuestOperation.</param>
        /// <param name="r">Packet BResponseQuestOperation.</param>
        public static void SendResponseQuestOperation(Session s, Package p, PacketBResponseQuestOperation r)
        {

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {r}");

            byte[] Response = r.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseQuestOperation, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

        /// <summary>
        /// Sends ResponseLaunchQuestMapPacket.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">Packet BRequestQuestOperation.</param>
        /// <param name="r">Packet PacketBResponseLaunchQuestMapPacket.</param>
        /// <note>Untraced package</note>
        public static void SendResponseLaunchQuestMapPacket(Session s, Package p, PacketBResponseLaunchQuestMapPacket r)
        {
            
            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {r}");

            byte[] Response = r.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseLaunchQuestMapPacket, 0, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
