/*
 *	Developed By: Aebian
 *	Name: SomeDebug
 *	Dependent: Rage Plugin Hook
 *	Released On: GitHub
 */

namespace SomeDebug.Utils
{
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Rage;
    using Rage.Native;

    internal static class Core
    {

        public static void RunPlugin()

        {

            Logger.DebugLog("Core Plugin Function Started");

            //Game loop
            while (true)
            {
                GameFiber.Yield();

                if ((Game.IsKeyDownRightNow(Global.Controls.CallDebugModifier) && Game.IsKeyDown(Global.Controls.CallDebug) || Global.Controls.CallDebugModifier == Keys.None && Game.IsKeyDown(Global.Controls.CallDebug)))
                {
                    Global.Dynamics.CurrentPlayerPos = Game.LocalPlayer.Character.Position;
                    Global.Dynamics.CurrentPlayerHeading = Game.LocalPlayer.Character.Heading;

                    DebugExecution();

                }
            }  

        }

        private static void DebugExecution()
        {



        }
       
    }

}

