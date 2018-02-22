using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;

using Libraries.helpers.server;
using Libraries.helpers.package;


namespace Chat
{

    [PackageChatCommandFilter]
    public class Server : AppServer<Session, PackageChat>
    {

        public Server() : base(new DefaultReceiveFilterFactory<PackageChatParser, PackageChat>())
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
