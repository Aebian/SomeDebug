/*
 *	Developed By: Aebian
 *	Name: SomeDebug
 *	Dependent: Rage Plugin Hook
 *	Released On: GitHub
 */

namespace SomeDebug.Utils
{
    using Rage;
    internal static class Logger
    {
        //Simple log line
        internal static void Log(string LogLine)
        {
            string log = string.Format(": {0}", LogLine);

            Game.LogTrivial(log);
        }

        //Simple log line that will be ran only if the global setting for debug logging is enabled
        internal static void DebugLog(string LogLine)
        {
            if (Global.Application.DebugLogging)
            {
                string log = string.Format("[DEBUG]: {0}", LogLine);

                Game.LogTrivial(log);
            }
        }
    }
}