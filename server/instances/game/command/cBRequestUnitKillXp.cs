using System;
using SuperSocket.SocketBase.Command;

using Libraries.character;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;
using Libraries.helpers.database;


namespace Game.Command
{

    public class BRequestUnitKillXp : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestUnitKillXp Request = new PacketBRequestUnitKillXp(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Character ObjCharacter = s.Player.Empire.CurrentCharacter;

            //@TODO
            // Level progress - Now character XP is renewed to last killed unit XP
            // Note: Last level has XP to gain
            //
            // int Level = ObjCharacter.Level;
            // int LevelXP = ObjCharacter.Resources.GetResource("XP");
            // int LevelXPMax = DatabaseHelper.GetMaximumXPforLevel(Level);
            // int LevelMax = DatabaseHelper.MaxCharacterlevel();

            ObjCharacter.Resources.SetResource("XP", Request.Xp);

            BRequestRetrievePersistentData.SendResponseCharacterDetails(s, p);

        }

    }

}
