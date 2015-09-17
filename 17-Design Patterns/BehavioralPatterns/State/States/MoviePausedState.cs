using System;

namespace State.States
{
    public class MoviePausedState : DVDPlayerState
    {
        public MoviePausedState()
        {
            Console.WriteLine("Movie paused");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            player.State = new MoviePlaingState();
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new MenuState();
        }
    }
}
