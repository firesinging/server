using System.ComponentModel;
using System.Configuration;
using System.ServiceProcess;

using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;


namespace Server
{

    /// <summary>
    /// MainService.
    /// </summary>
    /// <see cref="https://github.com/dib0/HL7Fuse/blob/master/HL7Fuse/MainService.cs"/>
    internal class MainService : ServiceBase
    {

        private IContainer components = (IContainer)null;
        private IBootstrap m_Bootstrap;

        public MainService()
        {

            this.InitializeComponent();
            this.m_Bootstrap = BootstrapFactory.CreateBootstrap();

        }

        protected override void OnStart(string[] args)
        {

            if (!this.m_Bootstrap.Initialize())
                return;

            int num = (int)this.m_Bootstrap.Start();

        }

        protected override void OnStop()
        {

            this.m_Bootstrap.Stop();

            base.OnStop();

        }

        protected override void OnShutdown()
        {

            this.m_Bootstrap.Stop();

            base.OnShutdown();

        }

        protected override void Dispose(bool disposing)
        {

            if (disposing && this.components != null)
                this.components.Dispose();

            base.Dispose(disposing);

        }

        private void InitializeComponent()
        {

            this.components = (IContainer)new Container();

            this.ServiceName = ConfigurationManager.AppSettings["ServiceName"];

        }

    }

}
