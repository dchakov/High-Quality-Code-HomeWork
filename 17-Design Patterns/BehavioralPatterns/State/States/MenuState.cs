using System;

namespace State.States
{
    public class MenuState : DVDPlayerState
    {
        public MenuState()
        {
            Console.WriteLine("Menu");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            Console.WriteLine("Next menu");
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new StandbyState();
        }
    }
}
