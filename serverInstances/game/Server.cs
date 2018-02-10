using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;

using Libraries.helpers.server;
using Libraries.helpers.package;


namespace Game
{

    [PackageCommandFilter]
    public class Server : AppServer<Session, Package>
    {

        public Server() : base(new DefaultReceiveFilterFactory<PackageParser, Package>())
        {

        }

        protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
        {

            return base.Setup(rootConfig, config);

        }

        public override bool Start()
        {

            if (ServerHelper.OnServerStart())
            {

                return base.Start();

            }
            else
            {

                Stop();

                return false;

            }            

        }

        public override void Stop()
        {

            base.Stop();

        }

        
    }

}
