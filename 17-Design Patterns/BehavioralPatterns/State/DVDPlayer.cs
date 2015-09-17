using State.States;

namespace State
{
    public class DVDPlayer
    {
        private DVDPlayerState state;

        public DVDPlayer()
        {
            this.state = new StandbyState();
        }

        public DVDPlayer(DVDPlayerState state)
        {
            this.state = state;
        }

        public void PressPlayButton()
        {
            this.state.PlayButtonPressed(this);
        }

        public void PressMenuButton()
        {
            this.state.MenuButtonPressed(this);
        }

        public DVDPlayerState State
        {
            get { return this.state; }
            set { this.state = value; }
        }
    }
}
