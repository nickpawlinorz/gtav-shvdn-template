using System;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.UI;

namespace template
{
    //Scripts need to implement abstract class Script to get loaded by SHVDN.
    public class Main : Script
    {
        // Will be executed on load (just one time)
        public Main()
        {
            Notification.Show("Script has been loaded!");
            // Adds event handler bindings
            Tick += OnTick;
            KeyDown += OnKeyDown;
        }

        // Gets called each Frame
        private void OnTick(object sender, EventArgs e)
        {
            //TODO: Do something
        }

        // Gets called on Mouse down
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                Notification.Show("Pressed ~b~NumPad1~w~!");
                //TODO: Do something
            }
        }
    }
} 