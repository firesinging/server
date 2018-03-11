﻿using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.player;
using Libraries.inventory;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestDestroyInventoryItem : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestDestroyInventoryItem Request = new PacketBRequestDestroyInventoryItem(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            //@TODO

        }

    }

}
