using System;

namespace State.States
{
    public class MoviePlaingState : DVDPlayerState
    {
        public MoviePlaingState()
        {
            Console.WriteLine("Movie Playing");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            player.State = new MoviePausedState();
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new MenuState();
        }
    }
}
