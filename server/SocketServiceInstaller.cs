using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.ServiceProcess;


namespace Server
{

    /// <summary>
    /// SocketServiceInstaller.
    /// </summary>
    /// <see cref="https://github.com/dib0/HL7Fuse/blob/master/HL7Fuse/SocketServiceInstaller.cs"/>
    [RunInstaller(true)]
    public class SocketServiceInstaller : Installer
    {

        private IContainer components = (IContainer)null;
        private ServiceInstaller serviceInstaller;
        private ServiceProcessInstaller processInstaller;

        public SocketServiceInstaller()
        {

            this.InitializeComponent();
            this.processInstaller = new ServiceProcessInstaller();
            this.serviceInstaller = new ServiceInstaller();
            this.processInstaller.Account = ServiceAccount.LocalSystem;
            this.serviceInstaller.StartType = ServiceStartMode.Automatic;
            this.serviceInstaller.ServiceName = ConfigurationManager.AppSettings["ServiceName"];

            string str1 = ConfigurationManager.AppSettings["ServiceDescription"];

            if (!string.IsNullOrEmpty(str1))
                this.serviceInstaller.Description = str1;

            List<string> list = new List<string>(){"tcpip"};

            string str2 = ConfigurationManager.AppSettings["ServicesDependedOn"];

            if (!string.IsNullOrEmpty(str2))
                list.AddRange((IEnumerable<string>)str2.Split(new char[2]{',', ';'}));

            this.serviceInstaller.ServicesDependedOn = list.ToArray();
            this.Installers.Add((Installer)this.serviceInstaller);
            this.Installers.Add((Installer)this.processInstaller);

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

        }

    }

}