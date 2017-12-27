using System.Configuration.Install;
using System.Reflection;


namespace Server
{

    /// <summary>
    /// Main program selfInstaller.
    /// </summary>
    /// <see cref="https://github.com/dib0/HL7Fuse/blob/master/HL7Fuse/SelfInstaller.cs"/>
    public static class SelfInstaller
    {

        private static readonly string _exePath = Assembly.GetExecutingAssembly().Location;

        static SelfInstaller()
        {
        }

        public static bool InstallMe()
        {

            try
            {

                ManagedInstallerClass.InstallHelper(new string[1]{SelfInstaller._exePath});
            }
            catch
            {

                return false;
            }

            return true;

        }

        public static bool UninstallMe()
        {

            try
            {

                ManagedInstallerClass.InstallHelper(new string[2]{"/u", SelfInstaller._exePath});

            }
            catch
            {

                return false;

            }

            return true;

        }

    }

}
