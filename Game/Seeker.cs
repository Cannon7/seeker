using System;


namespace Seeker.Game
{

    public class Seeker
    {
        //HIDES THE HIDER AND ASSIGNS IT A LOCATION
        private int _location = 0;

        public Seeker()
        {
            Random random = new Random();
            _location = random.Next(1001);
        }

        public int GetLocation()
        {
            return _location;
        }

        public void MoveLocation(int location)
        {
            this._location = location;
        }

    }
}