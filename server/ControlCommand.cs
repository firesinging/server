using SuperSocket.SocketBase;
using System;

namespace Server
{

    /// <summary>
    /// Add option for SuperSocket control commands.
    /// </summary>
    /// <see cref="https://github.com/dib0/HL7Fuse/blob/master/HL7Fuse/ControlCommand.cs"/>
    class ControlCommand
    {
                
        public string Name { get; set; }
        public string Description { get; set; }
        public Func<IBootstrap, string[], bool> Handler { get; set; }

    }

}
