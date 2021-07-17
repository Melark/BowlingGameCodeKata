using System;

namespace BowlingGame
{
    public class BowlerGame
    {
        public int Score()
        {
            return 0;
        }

        public void Roll(int numberOfPins)
        {
            if (numberOfPins > 10) throw new ArgumentException("Can not roll more than 10 pins at a time");
            if (numberOfPins < 0) throw new ArgumentException("Can not roll less than 0 pins at a time");
        }
    }
}