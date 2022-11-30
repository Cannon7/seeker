namespace Seeker.Game
{

    public class Director
    {
        private Hider _hider = new Hider();
        private bool _isPlaying = true;
        private Seeker _seeker = new Seeker();
        private TerminalService _terminalService = new TerminalService();


        public Director()
        {
        }

        public void StartGame()
        {
            while (_isPlaying)
            {
                //GAMEPLAY LOOP AND UPDATES
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        //LOCATION INPUT
        private void GetInputs()
        {
            _terminalService.WriteText(_hider._location.ToString());
            int location = _terminalService.ReadNumber("\nEnter a location [1-1000]: ");
            _seeker.MoveLocation(location);
        }

        //TRACK SEEKER
        private void DoUpdates()
        {
            _hider.WatchSeeker(_seeker);
        }

        //HINTS FOR THE WEAK
        private void DoOutputs()
        {
            string hint = _hider.GetHint();
            _terminalService.WriteText(hint);
            if (_hider.IsFound())
            {
                _isPlaying = false;
            }
            
        }
    }
}