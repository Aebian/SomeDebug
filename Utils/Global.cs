/*
 *	Developed By: Aebian
 *	Name: SomeDebug
 *	Dependent: Rage Plugin Hook
 *	Released On: GitHub
 */

namespace SomeDebug.Utils
{
    using System.Windows.Forms;
    using Rage;

    internal static class Global
    {
        internal static class Application
        {
            public static string CurrentVersion { get; set; }
            public static string LatestVersion { get; set; }
            public static bool DebugLogging { get; set; }
            public static string ConfigPath { get; set; }
        }

        internal static class Controls
        {
            public static Keys CallDebug { get; set; }
            public static Keys CallDebugModifier { get; set; }

        }

        internal static class Dynamics
        {
            public static Vector3 CurrentPlayerPos { get; set; }
            public static float CurrentPlayerHeading { get; set; }
        }
    }
}
