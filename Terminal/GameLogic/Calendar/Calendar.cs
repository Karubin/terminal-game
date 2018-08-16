using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.GameLogic
{
    class Calendar : GameObject
    {

        Game Game;
        public int Hour { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Calendar(Game game)
        {
            Game = game;

            Hour = 1;
            Day = 1;
            Month = 1;
            Year = 1900;

        }

        public override void Update()
        {
            Hour++;
            if (Hour >= 25)
            {
                Hour = 0;
                Day++;
            }
            if (Day >= 31)
            {
                Day = 1;
                Month++;
            }
            if (Month >= 13)
            {
                Month = 1;
                Year++;
            }
        }

        public override string ToString()
        {
            string t = (Hour < 10) ? "TIME: 0" + Hour + ":00 | " : "TIME: " + Hour + ":00 | ";
            string d = "DAY: " + Day + " | ";
            string m = "MONTH: " + Month + " | ";
            string y = "YEAR: " + Year;
            string result = t + d + m + y;
            return result;
        }
    }
}
