using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class Program
    {
        public static void Main()
        {
            DVDPlayer player = new DVDPlayer();
            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
        }
    }
}
