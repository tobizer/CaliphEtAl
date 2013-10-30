using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluxOfSouls
{
    class GameManager
    {
        SplashScreenGameComponent splashScreen;
        
        public GameManager(Game1 game, SplashScreenGameComponent splashScreen)
        {
            this.splashScreen = splashScreen;

            //Handlers
            splashScreen.VisibleChanged +=new EventHandler<EventArgs>(splashScreen_VisibleChanged);
        }

        void splashScreen_VisibleChanged(object sender, EventArgs e)
        {
            splashScreen.Visible = false;
            splashScreen.Enabled = false;
        }

        
    }
}
