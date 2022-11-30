using System;
using System.Collections.Generic;


namespace Seeker.Game
{
    public class Hider
    {
        public int _location = 0;
        private List<int> _distance = new List<int>();

        public Hider()
        {
            Random random = new Random();
            _location = random.Next(1001);
            _distance.Add(0);
            _distance.Add(0);
        }

        public string GetHint()
        {
            //HINTS FOR THE WEAK
            int current = _distance[_distance.Count - 1];
            int previous = _distance[_distance.Count - 2];

            string hint = "(-.-) Nap time.";
            if (current == 0)
            {
                hint = "(;.;) You found me!";
            }
            else if (current > previous)
            {
                hint = "(^.^) Getting colder!";
            }
            else if (current < previous)
            {
                hint = "(>.<) Getting warmer!";
            }

            return hint;
        }

        //IF GUESS IS = TO LOCATION
        public bool IsFound()
        {
            return _distance[_distance.Count - 1] == 0;
        }
        //TRACKS DISTANCES
        public void WatchSeeker(Seeker seeker)
        {
            int newDistance = Math.Abs(_location - seeker.GetLocation());
            _distance.Add(newDistance);
        }
    }
}