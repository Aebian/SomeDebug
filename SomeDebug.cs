/*
 *	Developed By: Aebian
 *	Name: SomeDebug
 *	Dependent: Rage Plugin Hook
 *	Released On: GitHub
 */

[assembly: Rage.Attributes.Plugin("SomeDebug", Author = "Aebian", Description = "Simple Debug Plugin with no real use", SupportUrl = "https://github.com/Aebian/SomeDebug")]

namespace SomeDebug {
    using Rage;
	using SomeDebug.Utils;

    public static class EntryPoint
    {

        private static void StartPlugin()
        {
            GameFiber.StartNew(delegate { Core.RunPlugin(); });
        }

        public static void Main() {
            Global.Application.ConfigPath = "Plugins/";
            Global.Application.CurrentVersion = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";

            Global.Controls.CallDebug = System.Windows.Forms.Keys.F7;
            Global.Controls.CallDebugModifier = System.Windows.Forms.Keys.LControlKey;

            Global.Application.DebugLogging = true;


            int versionStatus = Updater.CheckUpdate();
			if (versionStatus == -1) {
				Notifier.Notify("Plugin is out of date! (Current Version: ~r~" + Global.Application.CurrentVersion + " ~s~) - (Latest Version: ~g~" + Global.Application.LatestVersion + "~s~) Please update the plugin!");
				Logger.Log("Plugin is out of date. (Current Version: " + Global.Application.CurrentVersion + ") - (Latest Version: " + Global.Application.LatestVersion + ")");
			}
			else if(versionStatus == -2) {
				Logger.Log("There was an issue checking plugin versions, the plugin may be out of date!");
            }
			else if (versionStatus == 1) {
				Logger.Log("Current version of plugin is higher than the version reported, this could be an error that you may want to report!");
                Logger.Log(Global.Application.CurrentVersion);
			}
			else {
				Notifier.Notify("Silencer Plugin loaded!");
				Logger.Log("Plugin Version v" + Global.Application.CurrentVersion + " loaded successfully");
			}

			StartPlugin();
		}
	}
}
